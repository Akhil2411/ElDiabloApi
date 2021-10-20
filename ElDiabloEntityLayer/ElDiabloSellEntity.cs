using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDiabloEntityLayer
{
    public class ElDiabloSellEntity
    {
        public int SellId { get; set; }
        public string ItemName { get; set; }
        public double PricePerUnit { get; set; }
        public double TotalUnits { get; set; }
        public double TotalCost { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
    }
}
