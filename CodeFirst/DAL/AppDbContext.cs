using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryID);
            base.OnModelCreating(modelBuilder);
        }
        
        public override int SaveChanges()
        {
            ChangeTracker.Entries().ToList().ForEach(e =>
            {
                if (e.Entity is Product p)
                {
                    if (e.State == EntityState.Added)
                    {
                        p.CreateDate = DateTime.Now;
                        p.CreateUser = 1;
                    }
                }
                if (e.Entity is ProductFeature pf)
                {
                    if (e.State == EntityState.Added)
                    {
                        pf.CreateDate = DateTime.Now;
                        pf.CreateUser = 1;
                    }
                }
                if (e.Entity is Category c)
                {
                    if (e.State == EntityState.Added)
                    {
                        c.CreateDate = DateTime.Now;
                        c.CreateUser = 1;
                    }
                }
            });
            return base.SaveChanges();            
        }
    }
}
