using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class DtoProductsByCategory : DtoBase
    {
        public DtoProductsByCategory()
        {

        }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
