using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopFresh.Data;
using WebShopFresh.Mapping;
using WebShopFresh.Models.Dbo;
using WebShopFresh.Services.Implementation;
using WebShopFresh.Services.Interface;

namespace WebShopFresh.UnitTests
{
    public class WebShopSetup
    {
        protected IMapper Mapper {  get; private set; }
        protected ApplicationDbContext InMemoryDbContext;
        protected readonly List<Category> Categories;
        protected static string TestString = "test";



        public WebShopSetup()
        {
            SetupInMemoryContext();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });




            Mapper = mappingConfig.CreateMapper();
            Categories = GenerateCategories(100);
            
        }
       







        /// <summary>
        /// Generates and saves a list of categories with products to the database.
        /// </summary>
        /// <param name="number">The number of categories to generate.</param>
        /// <returns>The generated categories.</returns>
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

        /// <summary>
        /// Creates an instance of the ProductService with the provided database context or the in-memory context if none is provided.
        /// </summary>
        /// <param name="context">Optional: The database context to use.</param>
        /// <returns>An instance of the ProductService.</returns>
        protected IProductService GetProductService(ApplicationDbContext? context = null)
        {
            if(context != null)
            {
                return new ProductService(context, Mapper);
            }

            return new ProductService(InMemoryDbContext, Mapper);

        }

        /// <summary>
        /// Creates an instance of the CategoryService with the provided database context or the in-memory context if none is provided.
        /// </summary>
        /// <param name="context">Optional: The database context to use.</param>
        /// <returns>An instance of the CategoryService.</returns>
        protected ICategoryService GetCategoryService(ApplicationDbContext? context = null)
        {
            if (context != null)
            {
                return new CategoryService(context, Mapper);
            }

            return new CategoryService(InMemoryDbContext, Mapper);
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
