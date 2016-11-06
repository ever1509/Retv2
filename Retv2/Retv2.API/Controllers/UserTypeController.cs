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
    public class UserTypeController : ApiController
    {
        protected IRestaurantBusinessObject BusinessObject;
        public UserTypeController(IBusinessObjectService service)
        {
            BusinessObject = service.GetBusinessObject();
        }
        // GET: api/UserType
        public async Task<HttpResponseMessage> Get()
        {
            var response = new ComposedResponse<UserTypeViewModel>();

            try
            {
                response.Model = await Task.Run(() =>
                {

                    return BusinessObject.GetUserTypes().Select(item => (new UserTypeViewModel(item)));

                });
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // GET: api/UserType/5
        public async Task<HttpResponseMessage> Get(int id)
        {
            var response = new SingleResponse<UserTypeViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.GetUserType(new UserType(id));
                });
                response.Model = new UserTypeViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // POST: api/UserType
        public async Task<HttpResponseMessage> Post([FromBody]UserType value)
        {
            var response = new SingleResponse<UserTypeViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.CreateUserType(value);
                });
                response.Model = new UserTypeViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // PUT: api/UserType/5
        public async Task<HttpResponseMessage> Put(int id, [FromBody]UserType value)
        {
            var response = new SingleResponse<UserTypeViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.UpdateUserType(value);
                });
                response.Model = new UserTypeViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // DELETE: api/UserType/5
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var response = new SingleResponse<UserTypeViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.DeleteUserType(new UserType(id));
                });
                response.Model = new UserTypeViewModel(entity);
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
