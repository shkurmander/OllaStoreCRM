using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Source
    {
        public int SourceId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public float Taxes { get; set; }
    }
}
