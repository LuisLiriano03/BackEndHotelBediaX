using HotelBediaX.API.Utility;
using HotelBediaX.Application.Destinations.DTOs;
using HotelBediaX.Application.Destinations.Interfaces;
using HotelBediaX.Application.Destinations.Services;
using HotelBediaX.Application.GendersType.DTOs;
using HotelBediaX.Application.GendersType.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBediaX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersTypeController : ControllerBase
    {

        private readonly IGendersTypeService _gendersTypeService;

        public GendersTypeController(IGendersTypeService gendersTypeService)
        {
            _gendersTypeService = gendersTypeService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllGendersType()
        {
            var response = new Response<List<GetGendersType>>();

            try
            {
                response.status = true;
                response.value = await _gendersTypeService.GetAllGenderTypeAsync();
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
