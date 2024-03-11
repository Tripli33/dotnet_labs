using AutoMapper;
using Restaurant.BLL.DTOs.Client;
using Restaurant.BLL.DTOs.Dish;
using Restaurant.BLL.DTOs.Order;
using Restaurant.DAL.Entities;

namespace Restaurant.BLL.Utilities;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Client, ClientDto>();
        CreateMap<ClientForManipulationDto, Client>();
        CreateMap<Dish, DishDto>();
        CreateMap<DishForManipulationDto, Dish>();
        CreateMap<Order, OrderDto>();
        CreateMap<Order, OrderForClientDto>();
        CreateMap<OrderForManipulationDto, Order>();
    }
}