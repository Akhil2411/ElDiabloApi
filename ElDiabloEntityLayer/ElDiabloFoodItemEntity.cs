﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDiabloEntityLayer
{
    public class ElDiabloFoodItemEntity
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public double PricePerItem { get; set; }
        public double TotalStock { get; set; }

      
    }


}
