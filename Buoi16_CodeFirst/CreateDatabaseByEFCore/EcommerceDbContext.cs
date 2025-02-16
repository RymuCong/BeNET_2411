using CreateDatabaseByEFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace CreateDatabaseByEFCore
{
    public class EcommerceDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Entities.Attribute> Attributes { get; set; }
        public DbSet<AttributeType> AttributeTypes { get; set; }

        public DbSet<Variant> Variants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Kết nối đến SQL Server
            optionsBuilder.UseSqlServer("Server=THANHCONG;Database=EcommerceDatabase;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //// Cấu hình thêm nếu cần (Mapping hoặc Fluent API)
            modelBuilder.Entity<Entities.Attribute>().Property(d => d.Name).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Entities.Attribute>().HasIndex(d => d.AttributeTypeId);
            //modelBuilder.Entity<Deal>().Property(d => d.NguoiBan).IsRequired().HasMaxLength(100);

            modelBuilder.Entity<Variant>()
            .HasMany(v => v.Attributes)
            .WithMany(a => a.Variants)
            .UsingEntity<Dictionary<string, object>>(
                "VariantAttribute",
                j => j
                    .HasOne<Entities.Attribute>()
                    .WithMany()
                    .HasForeignKey("AttributeID"),
                j => j
                    .HasOne<Variant>()
                    .WithMany()
                    .HasForeignKey("VariantID"));
        }
    }
}
