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
    public class UserController : ApiController
    {
        protected IRestaurantBusinessObject BusinessObject;
        public UserController(IBusinessObjectService service)
        {
            BusinessObject = service.GetBusinessObject();
        }
        // GET: api/User
        public async Task<HttpResponseMessage> Get()
        {
            var response = new ComposedResponse<UserViewModel>();

            try
            {
                response.Model = await Task.Run(() =>
                {

                    return BusinessObject.GetUsers().Select(item => (new UserViewModel(item)));

                });
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // GET: api/User/5
        public async Task<HttpResponseMessage> Get(int id)
        {
            var response = new SingleResponse<UserViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.GetUser(new User(id));
                });
                response.Model = new UserViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // POST: api/User
        public async Task<HttpResponseMessage> Post([FromBody]User value)
        {
            var response = new SingleResponse<UserViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.CreateUser(value);
                });
                response.Model = new UserViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // PUT: api/User/5
        public async Task<HttpResponseMessage> Put(int id, [FromBody]User value)
        {
            var response = new SingleResponse<UserViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.UpdateUser(value);
                });
                response.Model = new UserViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // DELETE: api/User/5
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var response = new SingleResponse<UserViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.DeleteUser(new User(id));
                });
                response.Model = new UserViewModel(entity);
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
