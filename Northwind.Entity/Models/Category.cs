using Northwind.Entity.Base;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class Category : EntityBase
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
