using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Retv2.API.Services;
using System.Threading.Tasks;
using Retv2.API.Controllers;
using System.Net.Http;
using System.Web.Http;
using Retv2.API.Responses;
using Retv2.API.ViewModels;
using Retv2.Domain.EntityLayer;

namespace Retv2.API.Tests.Controllers
{
    [TestClass]
    public class CategoryControllerTest
    {
        protected IBusinessObjectService service;
        [TestInitialize]
        public void Init()
        {
            service = new BusinessObjectService();
        }
        [TestMethod]
        public async Task GetCategories()
        {
            //Arrange
            var controller = new CategoryController(service);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var result = await controller.Get();

            //Assert
            var response = default(ComposedResponse<CategoryViewModel>);
            result.TryGetContentValue(out response);
            Assert.IsNotNull(response.Model);
                        
        }
        [TestMethod]
        public async Task GetCategory()
        {
            //Arrange
            var controller = new CategoryController(service);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var result = await controller.Get(2);

            //Assert
            var response = default(SingleResponse<CategoryViewModel>);
            result.TryGetContentValue(out response);
            Assert.IsNotNull(response.Model);
        }
        [TestMethod]
        public async Task CreateCategory()
        {
            //Arrange
            var controller = new CategoryController(service);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var model = new Category()
            {
                CategoryName="",
                CategoryStatus=""                
            };
            var result = await controller.Post(model);

            //Assert
            var response = default(SingleResponse<CategoryViewModel>);
            result.TryGetContentValue(out response);
            Assert.IsNotNull(response.Model.CategoryName);
        }
        [TestMethod]
        public async Task UpdateCategory()
        {
            //Arrange
            var controller = new CategoryController(service);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var model = new Category()
            {
                CategoryID=2,
                CategoryName = "",
                CategoryStatus = ""
            };
            var result = await controller.Put(1,model);

            //Assert
            var response = default(SingleResponse<CategoryViewModel>);
            result.TryGetContentValue(out response);
            Assert.IsTrue(response.Message == "Record updated successfully!");
        }
        [TestMethod]
        public async Task DeleteCategory()
        {
            //Arrange
            var controller = new CategoryController(service);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act          
            var result = await controller.Delete(3);

            //Assert
            var response = default(SingleResponse<CategoryViewModel>);
            result.TryGetContentValue(out response);
            Assert.IsTrue(response.Message == "Record deleted successfully!");
        }
    }
}
