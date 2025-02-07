using Microsoft.EntityFrameworkCore;
using qrAdmin.Models;


namespace qrAdmin.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Menu> Menuler { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Urun>().ToTable("Urunler");
        }
    }
}
