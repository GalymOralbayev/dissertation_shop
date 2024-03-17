using Shop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.DataAccess
{
    public interface IOrderRepository
    {
        Order TryGetByUserId(string userId);
        IEnumerable<Order> GetOrdersInTwoDay(string userId);
        List<Order> TryGetAllByUserId(string userId);
        List<Order> GetAll();
        void AddProduct(int orderId, Product product, int amount);
        void Create(string userId, Product product, int amount);
        void AddInformation(Order orderInfo);
        void ChangeStatus(string status, int orderId);
        Order TryGetByOrderId(int orderId);
    }
}