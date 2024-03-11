using AutoMapper;
using Restaurant.BLL.Contracts;
using Restaurant.BLL.DTOs.Dish;
using Restaurant.BLL.Utilities.CustomExceptions;
using Restaurant.DAL.Contracts;
using Restaurant.DAL.Entities;

namespace Restaurant.BLL.Services;

public class DishService : IDishService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public DishService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }
    
    public async Task<DishDto> GetDishAsync(int id, bool trackChanges)
    {
        var dish = await _repositoryManager.DishRepository.GetDishByIdAsync(id, trackChanges);

        if (dish is null)
        {
            throw new DishNotFoundException(id);
        }

        var dishDto = _mapper.Map<DishDto>(dish)!;

        return dishDto;
    }

    public async Task<IEnumerable<DishDto>> GetDishesAsync(bool trackChanges)
    {
        var dishes = await _repositoryManager.DishRepository.GetAllDishesAsync(trackChanges);
        var dishesDto = _mapper.Map<IEnumerable<DishDto>>(dishes)!;

        return dishesDto;
    }

    public async Task<IEnumerable<DishDto>> GetDishesAsync(double minPrice, bool trackChanges)
    {
        var dishes = 
            await _repositoryManager.DishRepository.GetDishesByMinPriceAsync(minPrice, trackChanges);
        var dishesDto = _mapper.Map<IEnumerable<DishDto>>(dishes)!;

        return dishesDto;
    }

    public async Task<IEnumerable<DishWithOrdersDto>> GetDishesWithOrdersCount()
    {
        var dishesWithOrdersCount = 
            await _repositoryManager.DishRepository.GetDishesWithOrdersCountAsync();
        var dishesWithOrdersDto =
            dishesWithOrdersCount.Select(e => 
                new DishWithOrdersDto(_mapper.Map<DishDto>(e.dish), e.ordersCount));
        
        return dishesWithOrdersDto;
    }

    public async Task<DishDto> CreateDishAsync(DishForManipulationDto dishForManipulationDto)
    {
        var dish = _mapper.Map<Dish>(dishForManipulationDto)!;
        
        _repositoryManager.DishRepository.CreateDish(dish);
        await _repositoryManager.SaveAsync();

        var dishDto = _mapper.Map<DishDto>(dish)!;

        return dishDto;
    }

    public async Task UpdateDishAsync(int id, DishForManipulationDto dishForManipulationDto, bool trackChanges)
    {
        var dish = await _repositoryManager.DishRepository.GetDishByIdAsync(id, trackChanges);

        if (dish is null)
        {
            throw new DishNotFoundException(id);
        }

        _mapper.Map(dishForManipulationDto, dish);
        await _repositoryManager.SaveAsync();
    }

    public async Task DeleteDishAsync(int id, bool trackChanges)
    {
        var dish = await _repositoryManager.DishRepository.GetDishByIdAsync(id, trackChanges);

        if (dish is null)
        {
            throw new DishNotFoundException(id);
        }
        
        _repositoryManager.DishRepository.DeleteDish(dish);
        await _repositoryManager.SaveAsync();
    }
}