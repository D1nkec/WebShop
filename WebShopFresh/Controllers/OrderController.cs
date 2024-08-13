using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebShopFresh.Services.Interface;

namespace WebShopFresh.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public OrderController(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }






























        public IActionResult Index()
        {
            return View();
        }
    }
}
