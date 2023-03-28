using ChooseTheRestaurantApi.Services.Dtos.Request;
using ChooseTheRestaurantApi.Services.Dtos.Response;
using ChooseTheRestaurantApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChooseTheRestaurantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoteController : ControllerBase
    {
        private readonly IVoteService _voteService;

        public VoteController(IVoteService voteService)
        {
            _voteService = voteService;
        }

        /// <summary>
        /// Create new vote
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// VoteResponseDto
        /// </returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost("VotarRestaurante")]
        public VoteResponseDto CreateVote([FromBody] VoteRequestDto request)
        {
            var response = _voteService.CreateVote(request);

            return response;
        }

        /// <summary>
        /// Get all computed votes
        /// </summary>
        /// <returns>
        /// VoteResponseDto
        /// </returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet("RankingVotaçãodoDia")]
        public VoteResponseDto GetAllVotes()
        {
            var response = _voteService.GetAllVotes();

            return response;
        }

        /// <summary>
        /// Reset vote's table
        /// </summary>
        /// <returns>
        /// VoteResponseDto
        /// </returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost("ZerarVotaçãoDoDia")]
        public VoteResponseDto ResetVotes()
        {
            var response = _voteService.ResetVotes();

            return response;
        }
    }
}