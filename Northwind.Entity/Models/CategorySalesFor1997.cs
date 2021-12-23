using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class CategorySalesFor1997 : EntityBase
    {
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }
    }
}
