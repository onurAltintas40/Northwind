using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class CurrentProductList : EntityBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
