﻿using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class ProductSalesFor1997 : EntityBase
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSales { get; set; }
    }
}
