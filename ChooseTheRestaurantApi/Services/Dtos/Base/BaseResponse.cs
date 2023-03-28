using FluentValidation.Results;

namespace ChooseTheRestaurantApi.Services.Dtos.Base
{
    public abstract class BaseResponse
    {
        public int StatusCode { get; set; }
        public IEnumerable<ValidationFailure>? Errors { get; set; }
    }
}
