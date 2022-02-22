using SparkPlug.Core.Dto;
using SparkPlug.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug.Core.Interfaces.Services
{
    public interface ICustomerDataService
    {
        public Task<ResponseModel> CreateCustomerDataForm(CustomerFormDataDto customerFormDataDto);
    }
}
