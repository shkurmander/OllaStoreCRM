using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Calculation
    {
        public int CalculationId { get; set; }
        public List<Position> Positions { get; set; }
        public float PositionsPrice { get; set; }
        public float PositionsCostPrice { get; set; }
        public float ShippingCost { get; set; }
        public float Taxes { get; set; }
        public float TotalPrice { get; set; }
        public float NetProfit { get; set; }

    }
}
