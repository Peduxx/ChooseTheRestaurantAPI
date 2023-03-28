using ChooseTheRestaurantApi.Entities;
using FluentValidation;

namespace ChooseTheRestaurantApi.Services.Validators
{
    public class RestaurantValidator : AbstractValidator<Restaurant>
    {
        public RestaurantValidator()
        {
            RuleFor(restaurant => restaurant.Name).NotNull().NotEmpty();
        }
    }
}
