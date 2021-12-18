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
        }
    }
}
