using HotelBediaX.API.Utility;
using HotelBediaX.Application.RoomNumbers.DTOs;
using HotelBediaX.Application.RoomsType.DTOs;
using HotelBediaX.Application.RoomsType.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBediaX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsTypeController : ControllerBase
    {
        private readonly IRoomsTypeService _roomsTypeService;

        public RoomsTypeController(IRoomsTypeService roomsTypeService)
        {
            _roomsTypeService = roomsTypeService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllRoomsType()
        {
            var response = new Response<List<GetRoomsType>>();

            try
            {
                response.status = true;
                response.value = await _roomsTypeService.GetAllRoomsTypeAsync();

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
