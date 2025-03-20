using AutoMapper;
using WebShopFresh.Models.Dbo.AddressModels;
using WebShopFresh.Models.Dbo.CategoryModels;
using WebShopFresh.Models.Dbo.OrderModels;
using WebShopFresh.Models.Dbo.ProductModels;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Shared.Models.Binding.AddressModels;
using WebShopFresh.Shared.Models.Binding.CategoryModels;
using WebShopFresh.Shared.Models.Binding.OrderModels;
using WebShopFresh.Shared.Models.Binding.ProductModels;
using WebShopFresh.Shared.Models.ViewModel.AddressModels;
using WebShopFresh.Shared.Models.ViewModel.CategoryModels;
using WebShopFresh.Shared.Models.ViewModel.OrderModels;
using WebShopFresh.Shared.Models.ViewModel.ProductViewModels;
using WebShopFresh.Shared.Models.ViewModel.UserModel;



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

            // ORDER
            CreateMap<OrderUpdateBinding, Order>();
            CreateMap<OrderBinding, Order>();
            CreateMap<Order, OrderViewModel>()
                .ForMember(dest => dest.Buyer, opt => opt.MapFrom(src => src.Buyer))
                .ForPath(dest => dest.Buyer.Address, opt => opt.MapFrom(src => src.Buyer.Address));  // Ispravno mapiranje adrese

            CreateMap<OrderItemBinding, OrderItem>();
            CreateMap<OrderItemUpdateBinding, OrderItem>();
            CreateMap<OrderItem, OrderItemViewModel>();

        

            // APPLICATION USER
            CreateMap<ApplicationUserUpdateBinding, ApplicationUser>();
            CreateMap<ApplicationUser, ApplicationUserUpdateBinding>();
            CreateMap<ApplicationUser, ApplicationUserViewModel>();


            // ADDRESS
            CreateMap<Address, AddressUpdateBinding>();
            CreateMap<AddressBinding, Address>();
            CreateMap<AddressUpdateBinding, Address>();
            CreateMap<Address, AddressViewModel>(); 
            CreateMap<Address, AddressBinding>();
        }

    }
}
