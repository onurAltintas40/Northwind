using AutoMapper;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Entity.Mapper
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
            CreateMap<Customer, DtoCustomer>().ReverseMap();
            //CreateMap<Customer, ViewCustomer>().ReverseMap();
            CreateMap<Order, DtoOrder>().ReverseMap();
            CreateMap<Category, DtoCategory>().ReverseMap();
            CreateMap<CustomerCustomerDemo, DtoCustomerCustomerDemo>().ReverseMap();
            CreateMap<CustomerDemographic, DtoCustomerDemographic>().ReverseMap();
            CreateMap<Employee, DtoEmployee>().ReverseMap();
            CreateMap<EmployeeTerritory, DtoEmployeeTerritory>().ReverseMap();
            CreateMap<OrderDetail, DtoOrderDetail>().ReverseMap();
            CreateMap<Product, DtoProduct>().ReverseMap();
            CreateMap<Region, DtoRegion>().ReverseMap();
            CreateMap<Shipper, DtoShipper>().ReverseMap();
            CreateMap<Supplier, DtoSupplier>().ReverseMap();
            CreateMap<Territory, DtoTerritory>().ReverseMap();
        }
    }
}
