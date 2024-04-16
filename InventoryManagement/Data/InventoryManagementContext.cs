using Microsoft.EntityFrameworkCore;
using InventoryManagement.Models;

namespace InventoryManagement.Data
{
    public class InventoryManagementContext : DbContext
    {
        public InventoryManagementContext(DbContextOptions<InventoryManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCatalogType> ProductCatalogTypes { get; set; }
        public DbSet<ProductCatalog> ProductCatalog { get; set; }
        public DbSet<ProductDamaged> ProductDamageds { get; set; }
        public DbSet<ProductStock> ProductStocks { get; set; }
        public DbSet<ProductLog> ProductLogs { get; set; }
        public DbSet<Vendor> Vendors{get; set;}
        public DbSet<Purchase> Purchases{get; set;}
        public DbSet<PurchaseList> PurchaseLists{get; set;}
        public DbSet<PurchasePaymentReturnRecord> PurchasePaymentReturnRecords{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the ProductCatalogType entity
            modelBuilder.Entity<ProductCatalog>(entity =>
            {
            entity.HasOne(pc => pc.CatalogType)
            .WithMany(pct => pct.ProductCatalog)
            .HasForeignKey(pc => pc.CatalogTypeId)
            .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ProductStock>().HasOne(x=> x.ProductDamaged).WithOne(x => x.ProductStock);

            modelBuilder.Entity<ProductCatalogType>()
            .HasMany(pct => pct.ProductCatalog)
            .WithOne(pc => pc.CatalogType)
            .HasForeignKey(pc => pc.CatalogTypeId)
            .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<Account>()
            .HasOne(a => a.Institution)
            .WithOne(i => i.Account)
            .HasForeignKey<Institution>(i => i.DefaultAccountId);
        }
    }
}
