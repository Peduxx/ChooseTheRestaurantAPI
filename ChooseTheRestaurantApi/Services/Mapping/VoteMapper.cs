using ChooseTheRestaurantApi.Entities;
using ChooseTheRestaurantApi.Services.Dtos.Request;

namespace ChooseTheRestaurantApi.Services.Mapping
{
    public class VoteMapper
    {
        public Vote Map(VoteRequestDto request)
        {
            return new Vote()
            {
                RestaurantCode = request.RestaurantCode,
                PersonName = request.PersonName.ToUpper(),
                PersonCPF = request.PersonCPF,
                CreationDate = DateTime.Now
            };
        }
    }
}