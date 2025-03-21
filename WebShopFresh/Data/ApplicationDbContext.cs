﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShopFresh.Models.Dbo.AddressModels;
using WebShopFresh.Models.Dbo.CategoryModels;
using WebShopFresh.Models.Dbo.OrderModels;
using WebShopFresh.Models.Dbo.ProductModels;
using WebShopFresh.Models.Dbo.SessionModels;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Shared.Interfaces;



namespace WebShopFresh.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
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

            modelBuilder.Entity<Address>().HasData(
                  new Address
                  {
                      Id = 1,
                      City = "Zagreb",
                      Created = new DateTime(2024, 5, 22),
                      Country = "Hrvatska",
                      Street = "Maksimirska",
                      Number = "100",
                      Valid = true
                  });

            modelBuilder.Entity<Category>().HasData(

                 new Category
                 {
                     Id = 1,
                     Name = "Test kategorija",
                     Created = DateTime.Now,
                     Valid = true,
                     Description = "Test description",
                 },
                  new Category
                  {
                      Id = 2,
                      Name = "Electronics",
                      Created = DateTime.Now.AddDays(-10),
                      Valid = true,
                      Description = "Electronic devices and accessories"
                  },
    new Category
    {
        Id = 3,
        Name = "Books",
        Created = DateTime.Now.AddMonths(-2),
        Valid = true,
        Description = "Books of various genres"
    },
    new Category
    {
        Id = 4,
        Name = "Clothing",
        Created = DateTime.Now.AddMonths(-1),
        Valid = true,
        Description = "Men's, Women's, and Children's clothing"
    },
    new Category
    {
        Id = 5,
        Name = "Home Appliances",
        Created = DateTime.Now.AddYears(-1),
        Valid = true,
        Description = "Appliances and gadgets for home use"
    },
    new Category
    {
        Id = 6,
        Name = "Toys",
        Created = DateTime.Now.AddDays(-30),
        Valid = true,
        Description = "Toys for children of all ages"
    }

              );

            modelBuilder.Entity<Product>().HasData(

                 new Product
                 {
                     Id = 1,
                     Name = "Smartphone",
                     Created = DateTime.Now.AddDays(-5),
                     Valid = true,
                     Description = "Latest model smartphone with high-end features",
                     Price = 999,
                     CategoryId = 2,
                     ImageUrl = "/content/test-sku.jpg"
                 },
    new Product
    {
        Id = 2,
        Name = "Science Fiction Novel",
        Created = DateTime.Now.AddMonths(-2),
        Valid = true,
        Description = "A captivating science fiction novel",
        Price = 15,
        CategoryId = 3,
        ImageUrl = "/content/"
    },
    new Product
    {
        Id = 3,
        Name = "Men's T-Shirt",
        Created = DateTime.Now.AddMonths(-1),
        Valid = true,
        Description = "Comfortable cotton t-shirt",
        Price = 25,
        CategoryId = 4,
        ImageUrl = "content/test-sku.jpg"
    },
    new Product
    {
        Id = 4,
        Name = "Vacuum Cleaner",
        Created = DateTime.Now.AddYears(-1),
        Valid = true,
        Description = "High-efficiency vacuum cleaner",
        Price = 150,
        CategoryId = 5,
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
    },
    new Product
    {
        Id = 6,
        Name = "Action Figure",
        Created = DateTime.Now.AddDays(-10),
        Valid = true,
        Description = "Popular action figure toy",
        Price = 30,
        CategoryId = 6,
        ImageUrl = "/content/action-figure-496wpt-1.jpg"
    },
    new Product
    {
        Id = 7,
        Name = "Laptop",
        Created = DateTime.Now.AddDays(-20),
        Valid = true,
        Description = "High-performance laptop for work and play",
        Price = 1200,
        CategoryId = 2,
        ImageUrl = "/content/laptop.jpg"
    },
    new Product
    {
        Id = 8,
        Name = "Mystery Thriller",
        Created = DateTime.Now.AddMonths(-3),
        Valid = true,
        Description = "An intriguing mystery thriller novel",
        Price = 20,
        CategoryId = 3,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 9,
        Name = "Women's Jeans",
        Created = DateTime.Now.AddMonths(-2),
        Valid = true,
        Description = "Stylish and comfortable women's jeans",
        Price = 50,
        CategoryId = 4,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 10,
        Name = "Blender",
        Created = DateTime.Now.AddYears(-2),
        Valid = true,
        Description = "Multi-functional kitchen blender",
        Price = 80,
        CategoryId = 5,
        ImageUrl = "/content/blender.jpg"
    },
    new Product
    {
        Id = 11,
        Name = "Building Blocks",
        Created = DateTime.Now.AddDays(-15),
        Valid = true,
        Description = "Creative building blocks for children",
        Price = 40,
        CategoryId = 6,
        ImageUrl = "/content/BuildingBlocks.jpg"
    },
    new Product
    {
        Id = 12,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    }, new Product
    {
        Id = 13,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 14,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1315,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 15,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 16,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 17,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 18,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 19,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 20,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 21,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 22,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 23,
        Name = "TEST",
        Created = DateTime.Now,
        Valid = true,
        Description = "neki description",
        Price = 1525,
        CategoryId = 1,
        ImageUrl = "/content/test-sku.jpg"
    },
    new Product
    {
        Id = 24,
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
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SessionItem> SessionItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
       

    }
}
