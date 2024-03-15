using AutoMapper;
using Restaurant.BLL.DTOs.Client;
using Restaurant.BLL.DTOs.Client.Auth;
using Restaurant.BLL.DTOs.Dish;
using Restaurant.BLL.DTOs.Order;
using Restaurant.DAL.Entities;
using ClientDto = Restaurant.BLL.DTOs.Client.ClientDto;

namespace Restaurant.BLL.Utilities;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Client, ClientDto>();
        CreateMap<Client, DTOs.Client.Auth.ClientDto>();
        CreateMap<Client, ClientWithTokenDto>();
        CreateMap<ClientForManipulationDto, Client>();
        CreateMap<ClientForLoginDto, Client>();
        CreateMap<ClientForRegisterDto, Client>();
        CreateMap<Dish, DishDto>();
        CreateMap<DishForManipulationDto, Dish>();
        CreateMap<Order, OrderDto>();
        CreateMap<Order, OrderForClientDto>();
        CreateMap<OrderForManipulationDto, Order>();
    }
}