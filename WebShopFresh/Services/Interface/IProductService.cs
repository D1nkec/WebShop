﻿using WebShopFresh.Shared.Models.Binding.ProductModels;
using WebShopFresh.Shared.Models.ViewModel.CategoryModels;
using WebShopFresh.Shared.Models.ViewModel.ProductViewModels;



namespace WebShopFresh.Services.Interface
{
    public interface IProductService
    {
        Task<ProductViewModel> GetProduct(long id);
        Task<(List<ProductViewModel> products, List<CategoryViewModel> categories)> GetFilteredSortedProductsAndCategories(string searchString, string sortOrder, long? categoryId, bool? valid = true);
        Task<ProductViewModel> AddProduct(ProductBinding model);
        Task<ProductViewModel> UpdateProduct(ProductUpdateBinding model);
        Task<ProductViewModel> DeleteProduct(long id);
    }
}





