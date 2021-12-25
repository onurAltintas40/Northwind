using Northwind.Entity.Base;
namespace Northwind.Entity.Dto
{
    public class DtoEmployeeTerritory : DtoBase
    {
        public DtoEmployeeTerritory()
        {

        }
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }
    }
}
