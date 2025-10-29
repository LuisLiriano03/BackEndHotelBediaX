
using HotelBediaX.API.Utility;
using HotelBediaX.Application.Destinations.DTOs;
using HotelBediaX.Application.Destinations.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBediaX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {
        private readonly IDestinationsService _destinationsService;

        public DestinationsController(IDestinationsService destinationsService)
        {
            _destinationsService = destinationsService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllDestination()
        {
            var response = new Response<List<GetDestination>>();

            try
            {
                response.status = true;
                response.value = await _destinationsService.GetAllDestinationAsync();
                response.message = "Successful Destinations";
            }
            catch (Exception ex)
            {
                response.status = false;
                response.message = ex.Message;
            }

            return Ok(response);

        }


    }
}
