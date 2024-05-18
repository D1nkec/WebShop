using AutoMapper;
using WebShopFresh.Models.Dbo;
using WebShopFresh.Shared.Models.Binding;
using WebShopFresh.Shared.Models.ViewModel;

namespace WebShopFresh.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // PRODUCT
            CreateMap<ProductViewModel, ProductUpdateBinding>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductBinding, Product>();
            CreateMap<ProductUpdateBinding, Product>();

           // CATEGORY
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryBinding, Category>();
            CreateMap<CategoryUpdateBinding, Category>();
            CreateMap<CategoryViewModel, CategoryUpdateBinding>();
        }

    }
}
