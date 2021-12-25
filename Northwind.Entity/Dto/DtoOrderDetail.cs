﻿using Northwind.Entity.Base;
namespace Northwind.Entity.Dto
{
    public class DtoOrderDetail : DtoBase 
    {
        public DtoOrderDetail()
        {

        }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    }
}
