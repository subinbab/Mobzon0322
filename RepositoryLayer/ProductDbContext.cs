using DomainLayer;
using DomainLayer.ProductLayer;
using Microsoft.EntityFrameworkCore;
using System;

namespace RepositoryLayer
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Products> products { get; set; }
        public DbSet<ProductImages> images { get; set; }
        public DbSet<ProductBrand> productBrands { get; set; }
        public DbSet<ProductRams> productRams { get; set; }
        public DbSet<Rams> ram { get; set; }
        public DbSet<ProductStorage> productStorages { get; set; }
        public DbSet<Storage> storages { get; set; }
        public DbSet<ProductSimType> productSimTypes { get; set; }
        public DbSet<ProductCamFeatures> productCam { get; set; }
        public DbSet<ProductColor> productColors { get; set; }
        public DbSet<Colors> colors { get; set; }
        public DbSet<ProductType> types { get; set; }
        public DbSet<ProductOsFeatures> osFeatures { get; set; }
    }
}
