using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        virtual public  ICollection<ProductType> ProdType { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public float Weight { get; set; }
        public int ProductionTime { get; set; }
        virtual public ICollection<Material> Materials { get; set; }
        public float CostPrice { get; set; }
        public string Detatils { get; set; }
    }
}
