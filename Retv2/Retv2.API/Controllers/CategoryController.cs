using Retv2.API.Responses;
using Retv2.API.Services;
using Retv2.API.ViewModels;
using Retv2.Domain.BusinessLayer.Contracts;
using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Retv2.API.Controllers
{
    public class CategoryController : ApiController
    {
        protected IRestaurantBusinessObject BusinessObject;
        public CategoryController(IBusinessObjectService service)
        {
            BusinessObject = service.GetBusinessObject();
        }
        // GET: api/Category
        public async Task<HttpResponseMessage> Get()
        {
            var response = new ComposedResponse<CategoryViewModel>();

            try
            {
                response.Model = await Task.Run(() =>
                {

                    return BusinessObject.GetCategories().Select(item => (new CategoryViewModel(item)));

                });
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // GET: api/Category/5
        public async Task<HttpResponseMessage> Get(int id)
        {
            var response = new SingleResponse<CategoryViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.GetCategory(new Category(id));
                });
                response.Model = new CategoryViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // POST: api/Category
        public async Task<HttpResponseMessage> Post([FromBody]Category value)
        {
            var response = new SingleResponse<CategoryViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.CreateCategory(value);
                });
                response.Model = new CategoryViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // PUT: api/Category/5
        public async Task<HttpResponseMessage> Put(int id, [FromBody]Category value)
        {
            var response = new SingleResponse<CategoryViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.UpdateCategory(value);
                });
                response.Model = new CategoryViewModel(entity);
                response.Message = "Record updated successfully!";
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // DELETE: api/Category/5
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var response = new SingleResponse<CategoryViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.DeleteCategory(new Category(id));
                });
                response.Model = new CategoryViewModel(entity);
                response.Message = "Record deleted successfully!";
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
