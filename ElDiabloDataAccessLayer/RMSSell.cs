//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElDiabloDataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class RMSSell
    {
        public int SellId { get; set; }
        public string ItemName { get; set; }
        public double PricePerUnit { get; set; }
        public double TotalUnits { get; set; }
        public double TotalCost { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
    
        public virtual RMSFoodItem RMSFoodItem { get; set; }
        public virtual RMSOrder RMSOrder { get; set; }
    }
}
