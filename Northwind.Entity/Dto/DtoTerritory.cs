using Northwind.Entity.Base;

namespace Northwind.Entity.Dto
{
    public class DtoTerritory : DtoBase
    {
        public DtoTerritory()
        {
            
        }

        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }
    }
}
