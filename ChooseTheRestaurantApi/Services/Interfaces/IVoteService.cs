using ChooseTheRestaurantApi.Services.Dtos.Request;
using ChooseTheRestaurantApi.Services.Dtos.Response;

namespace ChooseTheRestaurantApi.Services.Interfaces
{
    public interface IVoteService
    {
        VoteResponseDto CreateVote(VoteRequestDto request);
        VoteResponseDto GetAllVotes();
        VoteResponseDto ResetVotes();
    }
}
