using System.Collections.Generic;
using System.Threading.Tasks;
using McRonald_Api.Model;

namespace McRonald_Api.Services;

public interface IOrderRepository
{
    Task<int> CreateOrder(int storeId);
    Task CancelOrder(string orderId);
    Task<List<Product>> GetMenu(int orderId);
    Task<List<Product>> GetOrderItems(int orderId);
    Task AddItem(int orderId, int productId);
    Task RemoveItem(int orderId, int itemId);
    Task FinishOrder(int orderId);
    Task DeliveryOrder(int orderId);
}