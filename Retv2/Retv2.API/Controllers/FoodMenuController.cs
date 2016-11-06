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
    public class FoodMenuController : ApiController
    {
        protected IRestaurantBusinessObject BusinessObject;
        public FoodMenuController(IBusinessObjectService service)
        {

            BusinessObject = service.GetBusinessObject();
        }
        // GET: api/FoodMenu
        public async Task<HttpResponseMessage> Get()
        {
            var response = new ComposedResponse<FoodMenuViewModel>();

            try
            {
                response.Model = await Task.Run(() =>
                {

                    return BusinessObject.GetFoodMenus().Select(item => (new FoodMenuViewModel(item)));

                });
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // GET: api/FoodMenu/5
        public async Task<HttpResponseMessage> Get(int id)
        {
            var response = new SingleResponse<FoodMenuViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.GetFoodMenu(new FoodMenu(id));
                });
                response.Model = new FoodMenuViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // POST: api/FoodMenu
        public async Task<HttpResponseMessage> Post([FromBody]FoodMenu value)
        {
            var response = new SingleResponse<FoodMenuViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.CreateFoodMenu(value);
                });
                response.Model = new FoodMenuViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // PUT: api/FoodMenu/5
        public async Task<HttpResponseMessage> Put(int id, [FromBody]FoodMenu value)
        {
            var response = new SingleResponse<FoodMenuViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.UpdateFoodMenu(value);
                });
                response.Model = new FoodMenuViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // DELETE: api/FoodMenu/5
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var response = new SingleResponse<FoodMenuViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.DeleteFoodMenu(new FoodMenu(id));
                });
                response.Model = new FoodMenuViewModel(entity);
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
