using Microsoft.EntityFrameworkCore;
using WebApplication3.Domain.Models;
namespace WebApplication3.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData
            (
                new Category { Id = 100, Name = "KADIN" }, // Id set manually due to in-memory provider
                new Category { Id = 101, Name = "KADIN BOT" },
                new Category { Id = 102, Name = "KADIN AYAKKABI" },
                new Category { Id = 103, Name = "KADIN LOAFER" },
                new Category { Id = 104, Name = "KADIN ÇİZME" },
                new Category { Id = 106, Name = "KADIN SNEAKERS" },
                new Category { Id = 107, Name = "KADIN SPOR" },
                new Category { Id = 108, Name = "KADIN BABET" },
                new Category { Id = 109, Name = "KADIN COMFORT" },
                new Category { Id = 110, Name = "ÇANTA" },
                new Category { Id = 111, Name = "ERKEK" },
                new Category { Id = 151, Name = "ERKEK BOT" },
                new Category { Id = 112, Name = "Üye OL" },
                new Category { Id = 113, Name = "Üye Girişi" },
                new Category { Id = 114, Name = "Sepetim " },
                new Category { Id = 115, Name = "Hakkımızda " },
                new Category { Id = 116, Name = "Gizlilik Güvenlik" },
                new Category { Id = 117, Name = "Hakkımızda " },
                new Category { Id = 118, Name = "Kullanım Şartları " },
                new Category { Id = 119, Name = "İletişim " },
                new Category { Id = 120, Name = "İptal Ve İADE Koşulları " },
                new Category { Id = 121, Name = "İşlem Rehberi " },
                new Category { Id = 122, Name = "Siparişlerim " },
                new Category { Id = 123, Name = "Alışveriş Sepetim " },
                new Category { Id = 124, Name = "Güvenli Alışveriş " }

            );

            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.QuantityInPackage).IsRequired();
            builder.Entity<Product>().Property(p => p.UnitOfMeasurement).IsRequired();
            builder.Entity<Product>().HasData
        (
         new Product
        {
            Id = 100,
            Name = "Örnek KADIN",
            QuantityInPackage = 1,
            UnitOfMeasurement = EUnitOfMeasurement.Unity,
            CategoryId = 100
        },
         new Product
        {
            Id = 101,
            Name = "Örnek KADIN BOT",
            QuantityInPackage = 13,
            UnitOfMeasurement = EUnitOfMeasurement.Unity,
            CategoryId = 101
        },
         new Product
         {
             Id = 102,
             Name = "Örnek KADIN AYAKKABI",
             QuantityInPackage = 2,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             CategoryId = 102
         },
         new Product
         {
             Id = 103,
             Name = "Örnek KADIN BOT",
             QuantityInPackage = 3,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             CategoryId = 103
         },
         new Product
         {
             Id = 104,
             Name = "Örnek KADIN LOAFER",
             QuantityInPackage = 4,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             CategoryId = 104
         },
         new Product
         {
             Id = 105,
             Name = "Örnek KADIN ÇİZME",
             QuantityInPackage = 5,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             CategoryId = 105
         },
         new Product
         {
             Id = 106,
             Name = "Örnek KADIN SNEAKERS",
             QuantityInPackage = 6,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             CategoryId = 106
         },
         new Product
         {
             Id = 107,
             Name = "Örnek KADIN SPOR",
             QuantityInPackage = 7,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             CategoryId = 107
         },
         new Product
         {
             Id = 108,
             Name = "Örnek KADIN BABET",
             QuantityInPackage = 8,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             CategoryId = 108
         },
         new Product
         {
             Id = 109,
             Name = "Örnek KADIN COMFORT",
             QuantityInPackage = 9,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             CategoryId = 109
         },
         new Product
         {
             Id = 110,
             Name = "Örnek ÇANTA Kategori",
             QuantityInPackage = 10,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             CategoryId = 110
         },
         new Product
          {
                Id = 111,
                Name = "Örnek ERKEK Kategori",
                QuantityInPackage = 11,
                UnitOfMeasurement = EUnitOfMeasurement.Unity,
                CategoryId = 111
          },
         new Product
         {
                  Id = 112,
                  Name = "Örnek Erkek Bot ",
                  QuantityInPackage = 14,
                  UnitOfMeasurement = EUnitOfMeasurement.Unity,
                  CategoryId = 112,
         } 
         );
        }
    }
}

