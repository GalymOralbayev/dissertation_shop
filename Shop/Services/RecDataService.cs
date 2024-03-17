using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.DataAccess;
using Shop.DataAccess.Models;
using Shop.Models;
using Shop.Recommendation;

namespace Shop.Services {
    public class RecDataService {
        private readonly IOrderRepository orderRepository;
        private readonly IRecDataRepository recDataRepository;
        private readonly IProductRepository productRepository;
        private readonly RecommendationService recommendationService;

        public RecDataService(IOrderRepository orderRepository, IRecDataRepository recDataRepository, 
            IProductRepository productRepository, RecommendationService recommendationService)
        {
            this.orderRepository = orderRepository;
            this.recDataRepository = recDataRepository;
            this.productRepository = productRepository;
            this.recommendationService = recommendationService;
        }

        public async Task AddRecData(string userId) {
            var orders = this.orderRepository.GetOrdersInTwoDay(userId).ToList();
            var lastOrder = orders?.OrderByDescending(x => x.DateTime).FirstOrDefault();
            var productsInLastOrder = lastOrder.OrderItems.Select(x => x.Product).ToList();
            
            foreach (var order in orders.Where(x => x.Id != lastOrder?.Id)) {
                foreach (var orderItem in order.OrderItems) {
                    foreach (var lastOrderOrderItem in lastOrder.OrderItems) {
                        var data = new RecData() {
                            ProductFromId = orderItem.Product.Id,
                            ProductToId = lastOrderOrderItem.Product.Id
                        };
                        await recDataRepository.AddRecDataAsync(data);
                    }
                }
            }

            var recDataList = PermutationGenerator(productsInLastOrder);
            foreach (var recData in recDataList) {
                await this.recDataRepository.AddRecDataAsync(recData);
            }
        }

        public async Task<List<Product>> GetRecommendedProducts(int productId)
        {
            var recProducts = await recommendationService.GetRecProducts(productId);
            var resultList = new List<Product>();
            foreach (var (productID, _) in recProducts)
            {
                resultList.Add(productRepository.Get(productID));
            }

            return resultList;
        }

        public async Task UpdateRecData()
        {
            await recommendationService.UpdateRecData();
        }

        private IEnumerable<RecData> PermutationGenerator(List<Product> products) {
            var resultList = new List<RecData>();

            foreach (var product in products)
            {
                resultList.AddRange(products
                    .Where(productToExclude => productToExclude .Id != product.Id)
                    .Select(selectedProduct => new RecData
                    {
                        ProductFromId = product.Id,
                        ProductToId = selectedProduct.Id
                    }));
            }

            return resultList;
        }
    }
}