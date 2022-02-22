using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SparkPlug.Core.Dto;
using SparkPlug.Core.Interfaces.Repository;
using SparkPlug.Core.Interfaces.Services;
using SparkPlug.Core.Models;
using System.Threading.Tasks;

namespace SparkPlug.Api.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class CustomerFormDataController : ControllerBase
    {
        private readonly ICustomerDataService _customerDataService;
        public CustomerFormDataController(ICustomerDataService customerDataService)
        {
            _customerDataService = customerDataService;
        }


        [HttpPost("CustomerDataForm")]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult<ResponseModel>> CustomerDataForm(CustomerFormDataDto customerFormDataDto)
        {
            try
            {
                var result = await _customerDataService.CreateCustomerDataForm(customerFormDataDto);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ResponseModel
                {
                    Message = ex?.Message ?? ex?.InnerException?.Message,
                    Success = false
                });
            }
            
        }
    }
}
