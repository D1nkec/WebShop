using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopFresh.Data;
using WebShopFresh.Mapping;
using WebShopFresh.Models.Dbo.AddressModels;
using WebShopFresh.Models.Dbo.CategoryModels;
using WebShopFresh.Models.Dbo.ProductModels;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Services.Implementation;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Dto;

namespace WebShopFresh.UnitTests
{
    public class WebShopSetup
    {
        protected IMapper Mapper { get; private set; }
        protected ApplicationDbContext InMemoryDbContext;
        protected ApplicationUser Buyer;
        protected readonly Address Address;
        protected readonly Mock<UserManager<ApplicationUser>> UserManager;
        protected readonly Mock<IOptions<AppSettings>> AppSettings;
        protected readonly List<Category> Categories;
        protected static string TestString = "test";



        public WebShopSetup()
        {
            SetupInMemoryContext();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });


            var userStoreMock = Mock.Of<IUserStore<ApplicationUser>>();
            UserManager = new Mock<UserManager<ApplicationUser>>(userStoreMock, null, null, null, null, null, null, null, null);
            Address = GenerateAddress();
            Mapper = mappingConfig.CreateMapper();
            Categories = GenerateCategories(100);

        }

        private Address GenerateAddress()
        {
            Address dbo = new Address
            {
                City = "Zagreb",
                Created = DateTime.Now,
                Country = "Hrvatska",
                Street = "Maksimirska",
                Number = "100",
                Valid = true
            };

            InMemoryDbContext.Addresses.Add(dbo);
            InMemoryDbContext.SaveChanges();

            return dbo;

        }
        protected List<Category> GenerateCategories(int number)
        {

            // Initialize the list of categories
            List<Category> response = new List<Category>();
            Random random = new Random();

            // Generate categories
            for (int i = 0; i < number; i++)
            {
                // Check if it's the first category
                if (i != 0)
                {
                    // Generate a category without products
                    Category listItem = new Category
                    {
                        Description = $"{nameof(Category.Description)} {random.Next(1, 1000)}",
                        Name = $"{nameof(Category.Name)} {random.Next(1, 1000)}",
                    };

                    response.Add(listItem);
                }
                else
                {
                    // Generate a category with products
                    Category listItem = new Category
                    {
                        Description = $"{nameof(Category.Description)} {random.Next(1, 1000)}",
                        Name = $"{TestString} {random.Next(1, 1000)}",
                        Products = new List<Product>()
                        {
                            // Add test products
                            new Product
                            {
                                Description = TestString,
                                Quantity = 15,
                                Price = 200,
                                Name = TestString
                            },
                            new Product
                            {
                                Description= TestString,
                                Quantity = 12,
                                Price = 210,
                                Name = TestString
                            }
                        }
                    };

                    response.Add(listItem);
                }
            }
            // Save categories to the database
            InMemoryDbContext.Categories.AddRange(response);
            InMemoryDbContext.SaveChanges();
            // Return the generated categories
            return response;
        }

      
        protected IProductService GetProductService(ApplicationDbContext? context = null)
        {
            if (context != null)
            {
                return new ProductService(context, null, Mapper);
            }

            return new ProductService(InMemoryDbContext, null, Mapper);
        }
        protected ICategoryService GetCategoryService(ApplicationDbContext? context = null)
        {
            if (context != null)
            {
                return new CategoryService(context, Mapper);
            }

            return new CategoryService(InMemoryDbContext, Mapper);
        }
        protected IOrderService GetOrderService(ApplicationDbContext? db = null)
        {
            if (db != null)
            {
                return new OrderService(UserManager.Object, db, Mapper);
            }
            return new OrderService(UserManager.Object, InMemoryDbContext, Mapper);
        }



        private ApplicationUser GetApplicationUser(ApplicationDbContext? db = null)
        {
            if (db == null)
            {
                db = InMemoryDbContext;
            }

            var email = Guid.NewGuid().ToString() + "@gmail.com";

            var user = new ApplicationUser
            {
                Address = Address,
                Email = email,
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                UserName = email

            };

            db.Users.Add(user);
            db.SaveChanges();
            return user;

        }


     

        private void SetupInMemoryContext()
            {
                // Configure options for the in-memory database context
                var inMemoryOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    // Specify the use of an in-memory database with a unique name
                    .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                    // Ignore specific warnings related to in-memory databases
                    .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                    // Build the options
                    .Options;

                InMemoryDbContext = new ApplicationDbContext(inMemoryOptions);
            }








        }
    }
