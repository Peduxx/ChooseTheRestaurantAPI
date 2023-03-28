using ChooseTheRestaurantApi.Data.Repositories.Interfaces;
using ChooseTheRestaurantApi.Services.Dtos.Request;
using ChooseTheRestaurantApi.Services.Dtos.Response;
using ChooseTheRestaurantApi.Services.Interfaces;
using ChooseTheRestaurantApi.Services.Mapping;
using ChooseTheRestaurantApi.Services.Validators;

namespace ChooseTheRestaurantApi.Services
{
    public class VoteService : IVoteService
    {
        private readonly IVoteRepository _voteRepository;
        private readonly VoteMapper _mapper;
        private readonly VoteValidator _validator;

        public VoteService(IVoteRepository voteRepository)
        {
            _voteRepository = voteRepository;
            _mapper = new VoteMapper();
            _validator = new VoteValidator();
        }

        public VoteResponseDto CreateVote(VoteRequestDto request)
        {
            try
            { 
                var vote = _mapper.Map(request);

                var validation = _validator.Validate(vote);

                var failures = validation.Errors.AsEnumerable();

                if (!validation.IsValid)
                {
                    return new VoteResponseDto(400, failures);
                }

                _voteRepository.Save(vote);

                return new VoteResponseDto(200);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public VoteResponseDto GetAllVotes()
        {
            try { 
                var votes = _voteRepository.GetAll();

                return new VoteResponseDto(200, null, votes);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public VoteResponseDto ResetVotes()
        {
            try
            { 
                _voteRepository.ResetVotes();

                return new VoteResponseDto(200);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
