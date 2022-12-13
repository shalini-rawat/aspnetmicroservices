using AutoMapper;
using EventBus.Messages.Events;
using OrderingApplication.Features.Orders.Commands.CheckoutOrder;

namespace OrderingAPI.Mapping
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
