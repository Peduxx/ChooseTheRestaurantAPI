using ChooseTheRestaurantApi.Services.Dtos.Request;
using ChooseTheRestaurantApi.Services.Dtos.Response;
using ChooseTheRestaurantApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChooseTheRestaurantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        /// <summary>
        /// Create new restaurant
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// RestaurantResponseDto
        /// </returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost("CadastraRestaurante")]
        public RestaurantResponseDto CreateRestaurant([FromBody] RestaurantRequestDto request)
        {
            var response = _restaurantService.CreateRestaurant(request);

            return response;
        }

        /// <summary>
        /// Get all restaurants
        /// </summary>
        /// <returns>
        /// RestaurantResponseDto
        /// </returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet("RetornaTodosRestaurantes")]
        public RestaurantResponseDto GetAllRestaurants()
        {
            var response = _restaurantService.GetAllRestaurants();

            return response;
        }

        /// <summary>
        /// Get the most voted restaurant
        /// </summary>
        /// <returns>
        /// RestaurantResponseDto
        /// </returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet("RestauranteVencedor")]
        public RestaurantResponseDto GetMostVotedRestaurant()
        {
            var response = _restaurantService.GetMostVotedRestaurant();

            return response;
        }

        /// <summary>
        /// Reset restaurant's table
        /// </summary>
        /// <returns>
        /// RestaurantResponseDto
        /// </returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost("ReiniciarRestaurantes")]
        public RestaurantResponseDto ResetRestaurants()
        {
            var response = _restaurantService.ResetRestaurants();

            return response;
        }
    }
}