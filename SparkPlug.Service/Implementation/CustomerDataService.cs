using SparkPlug.Core.Dto;
using SparkPlug.Core.Interfaces.Repository;
using SparkPlug.Core.Interfaces.Services;
using SparkPlug.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug.Service.Implementation
{
    public class CustomerDataService : ICustomerDataService
    {
        private readonly IRepository _repository;
        public CustomerDataService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResponseModel> CreateCustomerDataForm(CustomerFormDataDto customerFormDataDto)
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
                return result;
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex?.Message ?? ex?.InnerException?.Message, Success = false };
            }
        }
    }
}
