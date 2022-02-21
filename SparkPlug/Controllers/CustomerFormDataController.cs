using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SparkPlug.Core.Dto;
using SparkPlug.Core.Interfaces.Repository;
using SparkPlug.Core.Models;
using System.Threading.Tasks;

namespace SparkPlug.Api.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class CustomerFormDataController : ControllerBase
    {
        private readonly IRepository _repository;
        public CustomerFormDataController(IRepository repository)
        {
            _repository = repository;
        }


        [HttpPost("CustomerDataForm")]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult<ResponseModel>> CustomerDataForm(CustomerFormDataDto customerFormDataDto)
        {
            try
            {
                var formData = new CustomerFormData
                {
                    _formDomainName = customerFormDataDto._formDomainName,
                    CustomerEmail = customerFormDataDto.customerEmail,
                    CustomerMessage = customerFormDataDto.customerMessage,
                    CustomerName = customerFormDataDto.customerName,

                };
                var result = await _repository.Add(formData);
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
