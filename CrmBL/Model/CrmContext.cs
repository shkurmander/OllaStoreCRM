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
        public int CalculationId { get; set; }
        public CrmContext() : base("DBConnect") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product>   Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Source> Sources { get; set; }
    }
}
