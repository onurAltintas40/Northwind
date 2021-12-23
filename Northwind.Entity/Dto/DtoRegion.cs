using Northwind.Entity.Base;
namespace Northwind.Entity.Dto
{
    public class DtoRegion : DtoBase 
    {
        public DtoRegion()
        {
            
        }

        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
    }
}
