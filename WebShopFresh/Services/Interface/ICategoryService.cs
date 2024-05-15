using WebShopFresh.Shared.Models.Binding;
using WebShopFresh.Shared.Models.ViewModel;

namespace WebShopFresh.Services.Interface
{
    public interface ICategoryService
    {
        Task<CategoryViewModel> AddCategory(CategoryBinding model);
        Task<CategoryViewModel> GetCategory(long id);
        Task<List<CategoryViewModel>> GetCategories(bool? valid = true);
        Task<CategoryViewModel> UpdateCategory(CategoryUpdateBinding model);
        Task<CategoryViewModel> DeleteCategory(long id);
    }
}
