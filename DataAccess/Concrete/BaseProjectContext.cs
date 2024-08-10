using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
namespace DataAccess.Concrete
{
    public class BaseProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Task2;Trusted_Connection=True");
        }
        public DbSet<AboutMe> AboutMe { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Faq> Faq { get; set; }
        public DbSet<Travel> Travel { get; set; }
        


    }
}
