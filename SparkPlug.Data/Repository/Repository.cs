using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using SparkPlug.Core.Interfaces.Repository;
using SparkPlug.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly IConfiguration _configuration;
        private readonly MongoClient _client;
        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
            _client = new MongoClient(_configuration["DatabaseSettings:ConnectionString"]);
        }
      

        public async Task<ResponseModel> Add(CustomerFormData entity)
        {
            
            try
            {
                //Check for database: This function will create a database if one does not exist
                var database = _client.GetDatabase(entity._formDomainName);
                var customerDataFormCollection = database.GetCollection<CustomerFormData>("CustomerFormData");
                await customerDataFormCollection.InsertOneAsync(entity);
                return new ResponseModel { Message="Success",Success=true};
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex?.Message??ex?.InnerException?.Message, Success = false };
            }
           

        }
    }
}
