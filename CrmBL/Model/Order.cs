using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        virtual public ICollection<Customer> Customer { get; set; }
        virtual public ICollection<Position> Position { get; set; }
        public  List<Position> PositionsList { get; set; }
        virtual public ICollection<Source> Source { get; set; }
        public DateTime TimeStamp { get; set; }
        public Calculation Calculations { get; set; }
    }
}
