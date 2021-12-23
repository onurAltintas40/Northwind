using Northwind.Entity.Base;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class Shipper : EntityBase
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
