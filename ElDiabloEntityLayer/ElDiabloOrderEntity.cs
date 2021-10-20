using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDiabloEntityLayer
{
    public class ElDiabloOrderEntity
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string OrderDate { get; set; }
        public double OrderAmount { get; set; }
    }
}
