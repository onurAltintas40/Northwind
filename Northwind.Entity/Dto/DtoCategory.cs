using Northwind.Entity.Base;
namespace Northwind.Entity.Dto
{
    public class DtoCategory : DtoBase
    {
        public DtoCategory()
        {
           
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}
