using Microsoft.EntityFrameworkCore;
using WebShopFresh.Models.Dbo;
using WebShopFresh.Shared.Interfaces;
using WebShopFresh.Shared.Models.Binding;
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
                     Description = "Test description",
                    
                 }

              ); 
            
            modelBuilder.Entity<Product>().HasData(

                 new Product {
                     Id = 1, 
                     Name = "Test product", 
                     Created = DateTime.Now, 
                     Valid = true, 
                     Description = "Test description",
                     Price = 125,
                     CategoryId = 1,
                     ImageUrl = "/content/test-sku.jpg"
                 },
                 new Product {
                     Id = 2, 
                     Name = "TEST", 
                     Created = DateTime.Now, 
                     Valid = true, 
                     Description = "neki description",
                     Price = 125,
                     CategoryId = 1,
                     ImageUrl = "/content/test-sku.jpg"
                 },
                 new Product {
                     Id = 3, 
                     Name = "test", 
                     Created = DateTime.Now, 
                     Valid = true, 
                     Description = "Test description",
                     Price = 25,
                     CategoryId = 1,
                     ImageUrl = "/content/test-sku.jpg"
                 },
                   new Product
                   {
                       Id = 4,
                       Name = "TEST",
                       Created = DateTime.Now,
                       Valid = true,
                       Description = "neki description",
                       Price = 1125,
                       CategoryId = 1,
                       ImageUrl = "/content/test-sku.jpg"
                   },

                     new Product
                     {
                         Id = 5,
                         Name = "TEST",
                         Created = DateTime.Now,
                         Valid = true,
                         Description = "neki description",
                         Price = 1525,
                         CategoryId = 1,
                         ImageUrl = "/content/test-sku.jpg"
                     }

              );
        }




        public override int SaveChanges()
        {

            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is IBaseTableAtributes && (
                e.State == EntityState.Added || e.State == EntityState.Modified));


            foreach (var entityEntry in entries)
            {
                switch (entityEntry.State)
                {
                    case EntityState.Modified:
                        ((IBaseTableAtributes)entityEntry.Entity).Updated = DateTime.Now;
                        break;
                    case EntityState.Added:
                        ((IBaseTableAtributes)entityEntry.Entity).Valid = true;
                        ((IBaseTableAtributes)entityEntry.Entity).Created = DateTime.Now;
                        break;
                    default:
                        break;
                }

            }
            return base.SaveChanges();
        }



        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {

            var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is IBaseTableAtributes && (
              e.State == EntityState.Added
              || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                switch (entityEntry.State)
                {
                    case EntityState.Deleted:
                        entityEntry.State = EntityState.Modified;
                        ((IBaseTableAtributes)entityEntry.Entity).Valid = false;
                        break;
                    case EntityState.Modified:
                        ((IBaseTableAtributes)entityEntry.Entity).Updated = DateTime.Now;
                        break;
                    case EntityState.Added:
                        ((IBaseTableAtributes)entityEntry.Entity).Valid = true;
                        ((IBaseTableAtributes)entityEntry.Entity).Created = DateTime.Now;
                        break;
                    default:
                        break;
                }

            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }







        /// <summary>
        /// DB SET
        /// </summary>
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
      
     
        
    }
}
