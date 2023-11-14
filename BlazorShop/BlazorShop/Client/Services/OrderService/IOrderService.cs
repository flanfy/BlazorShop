namespace BlazorShop.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task<String> PlaceOrder();
        Task<List<OrderOverviewResponse>> GetOrders();
        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
