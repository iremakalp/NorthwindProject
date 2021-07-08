using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // Context: DB tablolari ile proje classlarini
    // iliskilendirme
    public class NorthwindContext : DbContext
    {
      
        public DbSet<Product> Products { get; set; }
    }
}
