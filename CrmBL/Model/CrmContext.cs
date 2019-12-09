using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class CrmContext : DbContext
    {
        
        public CrmContext() : base("DBConnect") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product>   Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Calculation> Calculations { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
