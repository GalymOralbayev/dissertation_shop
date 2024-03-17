using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.DataAccess.Models;

namespace Shop.DataAccess {
    public class RecDataDbRepository : IRecDataRepository
    {
        private readonly ShopContext shopContext;

        public RecDataDbRepository(ShopContext shopContext)
        {
            this.shopContext = shopContext;
        }

        public async Task<IEnumerable<RecData>> GetAllAsync() {
            var cart = await shopContext.RecData.ToListAsync();
            return cart;
        }

        public async Task AddRecDataAsync(RecData recData) {
            shopContext.RecData.Add(recData);
            await shopContext.SaveChangesAsync();
        }
    }
}