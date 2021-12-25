using Northwind.Entity.Base;


#nullable disable

namespace Northwind.Entity.Models
{
    public partial class DtoCategorySalesFor1997 : DtoBase
    {
        public DtoCategorySalesFor1997()
        {

        }
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }
    }
}
