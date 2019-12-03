using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Material
    {
        public int MaterialId { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public string [] Sources { get; set; }
    }
}
