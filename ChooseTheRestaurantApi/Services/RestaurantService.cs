using ChooseTheRestaurantApi.Data.Repositories.Interfaces;
using ChooseTheRestaurantApi.Entities;
using ChooseTheRestaurantApi.Services.Interfaces;
using ChooseTheRestaurantApi.Services.Mapping;
using ChooseTheRestaurantApi.Services.Validators;
using ChooseTheRestaurantApi.Services.Dtos.Response;
using ChooseTheRestaurantApi.Services.Dtos.Request;

namespace ChooseTheRestaurantApi.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly RestaurantMapper _mapper;
        private readonly RestaurantValidator _validator;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = new RestaurantMapper();
            _validator = new RestaurantValidator();
        }

        public RestaurantResponseDto CreateRestaurant(RestaurantRequestDto request)
        {
            try
            { 
                var restaurant = _mapper.Map(request);

                var validation = _validator.Validate(restaurant);

                var failures = validation.Errors.AsEnumerable();

                if (!validation.IsValid)
                {
                    return new RestaurantResponseDto(400, failures);
                }

                _restaurantRepository.Save(restaurant);

                return new RestaurantResponseDto(200);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public RestaurantResponseDto GetAllRestaurants()
        {
            try
            { 
                var restaurants = _restaurantRepository.GetAll();

                foreach (Restaurant restaurant in restaurants)
                { 
                    restaurant.Votes = _restaurantRepository.GetRestaurantVotes(restaurant.Code);
                }

                return new RestaurantResponseDto(200, null, restaurants);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RestaurantResponseDto GetMostVotedRestaurant()
        {
            try
            {
                var results = GetAllRestaurants();

                var mostVoted = results.Restaurants!.FirstOrDefault();

                foreach (Restaurant restaurant in results.Restaurants!)
                {
                    if (restaurant.Votes.Count > mostVoted!.Votes.Count)
                    {
                        mostVoted = restaurant;
                    }
                }

                return new RestaurantResponseDto(200, null, results
                                                                            .Restaurants
                                                                            .Where(restaurant => restaurant.Name == mostVoted!.Name)
                                                                            .ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RestaurantResponseDto ResetRestaurants()
        {
            try
            {
                _restaurantRepository.ResetRestaurants();

                return new RestaurantResponseDto(200);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
