using AutoMapper;
using OrderingApplication.Features.Orders.Commands.CheckoutOrder;
using OrderingApplication.Features.Orders.Commands.UpdateOrder;
using OrderingApplication.Features.Orders.Queries.GetOrdersList;
using OrderingDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingApplication.Contracts.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}
