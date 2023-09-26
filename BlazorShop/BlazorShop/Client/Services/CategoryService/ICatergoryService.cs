using BlazorShop.Client.Shared;

namespace BlazorShop.Client.Services.CategoryService
{
    public interface ICatergoryService
    {
        List<Category> Categories { get; set; }
        Task GetCategories();
    }
}
