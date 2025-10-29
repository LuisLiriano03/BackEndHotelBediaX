using HotelBediaX.API.Utility;
using HotelBediaX.Application.Destinations.DTOs;
using HotelBediaX.Application.RoomNumbers.DTOs;
using HotelBediaX.Application.RoomNumbers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBediaX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomNumbersController : ControllerBase
    {
        private readonly IRoomNumbersService _roomNumbersService;

        public RoomNumbersController(IRoomNumbersService roomNumbersService)
        {
            _roomNumbersService = roomNumbersService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllRoomNumbers()
        {
            var response = new Response<List<GetRoomNumbers>>();

            try
            {
                response.status = true;
                response.value = await _roomNumbersService.GetAllRoomNumbersAsync();

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
