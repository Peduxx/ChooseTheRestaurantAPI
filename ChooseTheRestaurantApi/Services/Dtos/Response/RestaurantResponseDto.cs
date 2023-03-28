using ChooseTheRestaurantApi.Entities;
using ChooseTheRestaurantApi.Services.Dtos.Base;
using FluentValidation.Results;

namespace ChooseTheRestaurantApi.Services.Dtos.Response
{
    public class RestaurantResponseDto : BaseResponse
    {
        public RestaurantResponseDto(int statusCode, IEnumerable<ValidationFailure>? errors = null, List<Restaurant>? restaurants = null)
        {
            StatusCode = statusCode;
            Errors = errors;
            Restaurants = restaurants;
        }

        public List<Restaurant>? Restaurants { get; set; }
    }
}