using SparkPlug.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug.Core.Interfaces.Repository
{
    public interface IRepository
    {

        public Task<ResponseModel> Add(CustomerFormData entity);

    }
}
