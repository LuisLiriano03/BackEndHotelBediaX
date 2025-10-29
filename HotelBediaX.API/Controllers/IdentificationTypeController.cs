using HotelBediaX.API.Utility;
using HotelBediaX.Application.Destinations.DTOs;
using HotelBediaX.Application.IdentificationsType.DTOs;
using HotelBediaX.Application.IdentificationsType.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBediaX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentificationTypeController : ControllerBase
    {
        private readonly IdentificationTypeService _identificationTypeService;

        public IdentificationTypeController(IdentificationTypeService identificationTypeService)
        {
            _identificationTypeService = identificationTypeService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllIdentificationType()
        {
            var response = new Response<List<GetIdentificationsType>>();

            try
            {
                response.status = true;
                response.value = await _identificationTypeService.GetAllIdentificationTypeAsync();
                response.message = "Successful Identification Type";
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
