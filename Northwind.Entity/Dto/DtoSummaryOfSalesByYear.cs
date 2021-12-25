using Northwind.Entity.Base;
using System;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class DtoSummaryOfSalesByYear : DtoBase
    {
        public DtoSummaryOfSalesByYear()
        {

        }
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
