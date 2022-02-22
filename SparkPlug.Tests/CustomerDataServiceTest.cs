using Moq;
using SparkPlug.Core.Dto;
using SparkPlug.Core.Interfaces.Repository;
using SparkPlug.Core.Interfaces.Services;
using SparkPlug.Core.Models;
using SparkPlug.Service.Implementation;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SparkPlug.Tests
{
    public class CustomerDataServiceTest
    {
        private readonly CustomerDataService _sut;
        private readonly Mock<IRepository> _repoMock = new Mock<IRepository>();
        public CustomerDataServiceTest()
        {
            _sut = new CustomerDataService(_repoMock.Object);
        }
        [Fact]
        public async Task ShouldReturnResponseModel()
        {
            //Arrange
            var data = new CustomerFormData
            {
                CustomerEmail = "test@test.com",
                CustomerMessage = "This is a test",
                CustomerName = "Tester Foo",
                _formDomainName = "website"
            };
            var dto = new CustomerFormDataDto
            {
                customerEmail = "test@test.com",
                customerMessage = "This is a test",
                customerName = "Tester Foo",
                _formDomainName = "website"
            };
            _repoMock.Setup(x => x.Add(It.IsAny<CustomerFormData>())).ReturnsAsync(() => new ResponseModel { Message = "Success", Success = true });

            //Act
            var response=await _sut.CreateCustomerDataForm(dto);

            //Assert

            Assert.NotNull(response);
            Assert.True(response.Success);
        }



    }
}

