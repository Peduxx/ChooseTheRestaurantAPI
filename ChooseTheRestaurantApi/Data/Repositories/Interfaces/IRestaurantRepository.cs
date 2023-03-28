using ChooseTheRestaurantApi.Entities;

namespace ChooseTheRestaurantApi.Data.Repositories.Interfaces
{
    public interface IRestaurantRepository
    {
        void Save(Restaurant restaurant);
        List<Restaurant> GetAll();
        List<Vote> GetRestaurantVotes(int code);
        void ResetRestaurants();
    }
}
