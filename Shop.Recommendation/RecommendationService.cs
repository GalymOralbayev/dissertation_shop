using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Shop.DataAccess;
using Shop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Recommendation {
    public class RecommendationService {
        private readonly IRecDataRepository _recDataRepository;
        public IConfiguration Configuration { get; }

        private static string TrainingDataRelativePath = $"Data/recdata.txt";
        private static string TrainingDataLocation = GetAbsolutePath(TrainingDataRelativePath);

        public RecommendationService(IRecDataRepository recDataRepository, IConfiguration configuration) {
            _recDataRepository = recDataRepository;
            Configuration = configuration;
        }

        public async Task<IEnumerable<(int ProductID, float Score)>> GetRecProducts(int productId) {
            MLContext mlContext = new MLContext();

            var traindata = mlContext.Data.LoadFromTextFile(path: TrainingDataLocation,
                columns: new[] {
                    new TextLoader.Column("Label", DataKind.Single, 0),
                    new TextLoader.Column(name: nameof(ProductEntry.ProductID), dataKind: DataKind.UInt32,
                        source: new[] { new TextLoader.Range(0) }, keyCount: new KeyCount(262111)),
                    new TextLoader.Column(name: nameof(ProductEntry.CoPurchaseProductID), dataKind: DataKind.UInt32,
                        source: new[] { new TextLoader.Range(1) }, keyCount: new KeyCount(262111))
                },
                hasHeader: true,
                separatorChar: '\t');

            MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
            options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
            options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
            options.LabelColumnName = "Label";
            options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
            options.Alpha = 0.01;
            options.Lambda = 0.025;

            var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

            ITransformer model = est.Fit(traindata);

            var predictionengine = mlContext.Model.CreatePredictionEngine<ProductEntry, CopurchasePrediction>(model);

            var top5 = (from m in Enumerable.Range(1, 262111)
                let p = predictionengine.Predict(
                    new ProductEntry() {
                        ProductID = (uint)productId,
                        CoPurchaseProductID = (uint)m
                    })
                orderby p.Score descending
                select (ProductID: m, Score: p.Score)).Take(5);

            return top5;
        }

        private static string GetAbsolutePath(string relativeDatasetPath) {
            FileInfo _dataRoot = new FileInfo(typeof(RecommendationService).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            string fullPath = Path.Combine(assemblyFolderPath, relativeDatasetPath);

            return fullPath;
        }

        public async Task<bool> UpdateRecData() {
            try {
                var recData = await _recDataRepository.GetAllAsync();

                using (StreamWriter writer = new StreamWriter(TrainingDataLocation)) {
                    foreach (var entry in recData) {
                        writer.WriteLine($"{entry.ProductFromId}\t{entry.ProductToId}");
                    }
                }

                return true;
            }
            catch (Exception e) {
                return false;
            }
        }
    }
}