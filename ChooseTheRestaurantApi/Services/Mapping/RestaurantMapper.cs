using ChooseTheRestaurantApi.Entities;
using ChooseTheRestaurantApi.Services.Dtos.Request;

namespace ChooseTheRestaurantApi.Services.Mapping
{
    public class RestaurantMapper
    {
        public Restaurant Map(RestaurantRequestDto request)
        {
            return new Restaurant()
            {
                Name = request.Name.ToUpper(),
                CreationDate = DateTime.Now
            };
        }
    }
}
