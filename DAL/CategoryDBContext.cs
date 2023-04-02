using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDBContext : DbContext
    {
      

        public CategoryDBContext() : base("name=CategoryDB") { }

        public DbSet<News> News { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
