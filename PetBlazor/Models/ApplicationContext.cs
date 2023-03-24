using Microsoft.EntityFrameworkCore;

namespace PetBlazor.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Bucket> Buckets { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //    modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = "Admin" }, new Role { Id = 2, Name = "User" });
        //    modelBuilder.Entity<User>().HasData(
        //    new User
        //    {
        //        Id = 1,
        //        Age = ThreadSafeRandom.Next(16, 48),
        //            CreatedDate = DateTime.Now,
        //            Email = "db@mail.ru",
        //            Name = "Dinar",
        //            Password = "123",
        //            RoleId = 1
        //        },
        //        new User
        //        {
        //            Id = 2,
        //            Age = ThreadSafeRandom.Next(16, 48),
        //            CreatedDate = DateTime.Now,
        //            Email = "alex@mail.ru",
        //            Name = "Alex",
        //            Password = "321",
        //            RoleId = 2
        //        });
            modelBuilder.Entity<Manufacturer>().HasData(manufacturers);
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Category>().HasData(categs);
        }

        List<Manufacturer> manufacturers = new List<Manufacturer>()
        {
                new Manufacturer{
                    Id = 1,
                    Name = "Nestle",
                },
                new Manufacturer
                {
                    Id = 2,
                    Name = "Propan",
                },
                new Manufacturer
                {
                    Id = 3,
                    Name = "Moscows"
                },
                new Manufacturer
                {
                    Id = 4,
                    Name = "Kazanskiy"
                }
        };
        public List<Category> categs = new List<Category>()
        {
            new Category
            {
                Id = 1,
                Name = "Мучное"
            },
            new Category
            {
                Id = 2,
                Name = "Фрукты"
            },
            new Category
            {
                Id = 3,
                Name = "Овощи"
            },
            new Category
            {
                Id = 4,
                Name = "Сладкое"
            }
        };
        public List<Product> products = new List<Product>()
        {
                new Product
                {
                    Id = 1,
                    Name = "Хлебцы",
                    Description = "Smt",
                    CategoryId = 1,
                    ManufacturerId = 1,
                },
                new Product
                {
                    Id = 2,
                    Name = "Бананы",
                    Description = "Smt",
                    CategoryId = 2,
                    ManufacturerId = 2,
                },
                new Product
                {
                    Id = 3,
                    Name = "Печенья",
                    Description = "Smt",
                    CategoryId = 4,
                    ManufacturerId = 1,
                },
                new Product
                {
                    Id = 4,
                    Name = "Шоколад",
                    Description = "Smt",
                    CategoryId = 4,
                    ManufacturerId = 3,
                },
                new Product
                {
                    Id = 5,
                    Name = "Помидоры",
                    Description = "Smt",
                    CategoryId = 3,
                    ManufacturerId = 3,
                },
                new Product
                {
                    Id = 6,
                    Name = "Огурец",
                    Description = "Smt",
                    CategoryId = 3,
                    ManufacturerId = 2,
                },
                new Product
                {
                    Id = 7,
                    Name = "Конфеты",
                    Description = "Smt",
                    CategoryId = 4,
                    ManufacturerId = 1,
                },
                new Product
                {
                    Id = 8,
                    Name = "Груши",
                    Description = "Smt",
                    CategoryId = 2,
                    ManufacturerId = 3,
                },
                new Product
                {
                    Id = 9,
                    Name = "Клубника",
                    Description = "Smt",
                    CategoryId = 2,
                    ManufacturerId = 2,
                },
                new Product
                {
                    Id = 10,
                    Name = "Печенье пресное",
                    Description = "Smt",
                    CategoryId = 1,
                    ManufacturerId = 2,
                }
        };
        List<Role> roles = new List<Role>
        {
                new Role
                {
                    Id = 1,
                    Name = "User"
                },
                new Role
                {
                    Id = 2,
                    Name = "Admin"
                }
        };
        List<User> users = new List<User>
        {
                new User
                {
                    Id = 1,
                    Name = "Test",
                    RoleId = 1,
                    Password = "111",
                    Email = "test@mail.ru",
                },
                new User
                {
                    Id = 2,
                    Name = "Somet",
                    RoleId = 2,
                    Password = "222",
                    Email = "smt@mail.ru",
                }
        };
    }
}
