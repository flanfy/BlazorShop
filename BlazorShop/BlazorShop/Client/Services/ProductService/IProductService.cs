namespace BlazorShop.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged; //invoke when products list is changed
        List<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
