using Northwind.Entity.Base;
using System;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class SalesTotalsByAmount : EntityBase
    {
        public decimal? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
