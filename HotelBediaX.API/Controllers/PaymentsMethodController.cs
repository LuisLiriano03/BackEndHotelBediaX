using HotelBediaX.API.Utility;
using HotelBediaX.Application.PaymentsMethod.DTOs;
using HotelBediaX.Application.PaymentsMethod.Interfaces;
using HotelBediaX.Application.RoomNumbers.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBediaX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsMethodController : ControllerBase
    {
        private readonly IPaymentsMethodService _paymentsMethodService;

        public PaymentsMethodController(IPaymentsMethodService paymentsMethodService)
        {
            _paymentsMethodService = paymentsMethodService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllPaymentsMethod()
        {
            var response = new Response<List<GetPaymentsMethod>>();

            try
            {
                response.status = true;
                response.value = await _paymentsMethodService.GetAllPaymentsMethodAsync();

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
