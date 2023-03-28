using ChooseTheRestaurantApi.Entities;
using ChooseTheRestaurantApi.Services.Dtos.Base;
using FluentValidation.Results;

namespace ChooseTheRestaurantApi.Services.Dtos.Response
{
    public class VoteResponseDto : BaseResponse
    {
        public VoteResponseDto(int statusCode, IEnumerable<ValidationFailure>? errors = null, List<Vote>? votes = null)
        {
            StatusCode = statusCode;
            Errors = errors;
            Votes = votes;
        }

        public List<Vote>? Votes { get; set; }
    }
}
