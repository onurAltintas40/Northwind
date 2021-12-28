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
            CreateMap<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>().ReverseMap();
            CreateMap<CategorySalesFor1997, DtoCategorySalesFor1997>().ReverseMap();
            CreateMap<CurrentProductList, DtoCurrentProductList>().ReverseMap();
            CreateMap<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>().ReverseMap();
            CreateMap<Invoice, DtoInvoice>().ReverseMap();
            CreateMap<OrderDetailsExtended, DtoOrderDetailsExtended>().ReverseMap();
            CreateMap<OrdersQry, DtoOrdersQry>().ReverseMap();
            CreateMap<OrderSubtotal, DtoOrderSubtotal>().ReverseMap();
            CreateMap<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>().ReverseMap();
            CreateMap<ProductSalesFor1997, DtoProductSalesFor1997>().ReverseMap();
            CreateMap<ProductsByCategory, DtoProductsByCategory>().ReverseMap();
            CreateMap<QuarterlyOrder, DtoQuarterlyOrder>().ReverseMap();
            CreateMap<SalesByCategory, DtoSalesByCategory>().ReverseMap();
            CreateMap<SalesTotalsByAmount, DtoSalesTotalsByAmount>().ReverseMap();
            CreateMap<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>().ReverseMap();
            CreateMap<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>().ReverseMap();
        }
    }
}
