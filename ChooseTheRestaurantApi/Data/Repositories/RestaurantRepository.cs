using ChooseTheRestaurantApi.Data.Repositories.Interfaces;
using ChooseTheRestaurantApi.Entities;

namespace ChooseTheRestaurantApi.Data.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly DataContext _context;

        public RestaurantRepository(DataContext context)
        {
            _context = context;
        }
        public void Save(Restaurant restaurant)
        {
            var RestaurantAlreadyExists = GetRestaurant(restaurant);

            if (!RestaurantAlreadyExists)
            {
                _context.Add(restaurant);
                _context.SaveChanges();
            }
        }

        public List<Restaurant> GetAll()
        {
            List<Restaurant> restaurants = _context.Restaurants.ToList();

            return restaurants;
        }

        public void ResetRestaurants()
        {
            var restaurants = GetAll();

            _context.RemoveRange(restaurants);
            _context.SaveChanges();
        }


        public List<Vote> GetRestaurantVotes(int code)
        {
            List<Vote> voteList = _context.Votes.Where(votes => votes.RestaurantCode == code).ToList();

            return voteList;
        }

        private bool GetRestaurant(Restaurant restaurant)
        {
            var response = _context.Restaurants.Any(data => data.Name == restaurant.Name);

            return response;
        }
    }
}
