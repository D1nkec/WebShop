using Microsoft.EntityFrameworkCore;
using WebShopFresh.Models.Dbo;
using WebShopFresh.Shared.Models.ViewModel;

namespace WebShopFresh.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>().HasData(

                 new Category {
                     Id = 1, 
                     Name = "Test kategorija",
                     Created = DateTime.Now, 
                     Valid = true, 
                     Description = "Test description" }

              ); 
            
            modelBuilder.Entity<Product>().HasData(

                 new Product {
                     Id = 1, 
                     Name = "Test product", 
                     Created = DateTime.Now, 
                     Valid = true, 
                     Description = "Test description",
                     Price = 125,
                     CategoryId = 1
                     
                 }

              );
        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<WebShopFresh.Shared.Models.ViewModel.ProductViewModel> ProductViewModel { get; set; } = default!;
        
    }
}
