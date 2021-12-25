using Northwind.Entity.Base;
using System;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class SummaryOfSalesByQuarter : EntityBase
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
