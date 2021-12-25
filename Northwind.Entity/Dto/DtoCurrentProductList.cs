using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class DtoCurrentProductList : DtoBase
    {
        public DtoCurrentProductList()
        {

        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
