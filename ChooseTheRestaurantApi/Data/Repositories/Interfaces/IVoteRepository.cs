using ChooseTheRestaurantApi.Entities;

namespace ChooseTheRestaurantApi.Data.Repositories.Interfaces
{
    public interface IVoteRepository
    {
        void Save(Vote vote);
        List<Vote> GetAll();
        void ResetVotes();
    }
}
