using ChooseTheRestaurantApi.Data.Repositories.Interfaces;
using ChooseTheRestaurantApi.Entities;

namespace ChooseTheRestaurantApi.Data.Repositories
{
    public class VoteRepository : IVoteRepository
    {
        private readonly DataContext _context;

        public VoteRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Vote vote)
        {
            var PersonVoteAlreadyExists = PersonVote(vote);

            if (!PersonVoteAlreadyExists)
            {
                _context.Add(vote);
                _context.SaveChanges();
            }
        }

        public List<Vote> GetAll()
        {
            List<Vote> votes = _context.Votes.ToList();

            return votes;
        }

        public void ResetVotes()
        {
            var votes = GetAll();

            _context.RemoveRange(votes);
            _context.SaveChanges();
        }

        private bool PersonVote(Vote vote)
        {
            var response = _context.Votes.Any(data => data.PersonCPF == vote.PersonCPF);

            return response;
        }
    }
}
