using ChooseTheRestaurantApi.Entities;
using ChooseTheRestaurantApi.Services.Dtos.Request;
using ChooseTheRestaurantApi.Services.Dtos.Response;

namespace ChooseTheRestaurantApi.Services.Interfaces
{
    public interface IRestaurantService
    {
        RestaurantResponseDto CreateRestaurant(RestaurantRequestDto request);
        RestaurantResponseDto GetAllRestaurants();
        RestaurantResponseDto GetMostVotedRestaurant();
        RestaurantResponseDto ResetRestaurants();
    }
}
