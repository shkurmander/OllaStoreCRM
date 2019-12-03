using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Position
    {
        public int PositionId { get; set; }
        virtual public ICollection<Product> Product { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }
    }
}
