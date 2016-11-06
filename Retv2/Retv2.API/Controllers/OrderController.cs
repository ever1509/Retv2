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
    public class OrderController : ApiController
    {
        protected IRestaurantBusinessObject BusinessObject;
        public OrderController(IBusinessObjectService service)
        {
            BusinessObject = service.GetBusinessObject();
        }
        // GET: api/Order
        public async Task<HttpResponseMessage> Get()
        {
            var response = new ComposedResponse<OrderViewModel>();

            try
            {
                response.Model = await Task.Run(() =>
                {

                    return BusinessObject.GetOrders().Select(item => (new OrderViewModel(item)));

                });
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // GET: api/Order/5
        public async Task<HttpResponseMessage> Get(int id)
        {
            var response = new SingleResponse<OrderViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.GetOrder(new Order(id));
                });
                response.Model = new OrderViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // POST: api/Order
        public async Task<HttpResponseMessage> Post([FromBody]Order value)
        {
            var response = new SingleResponse<OrderViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.CreateOrder(value);
                });
                response.Model = new OrderViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // PUT: api/Order/5
        public async Task<HttpResponseMessage> Put(int id, [FromBody]Order value)
        {
            var response = new SingleResponse<OrderViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.UpdateOrder(value);
                });
                response.Model = new OrderViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // DELETE: api/Order/5
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var response = new SingleResponse<OrderViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.DeleteOrder(new Order(id));
                });
                response.Model = new OrderViewModel(entity);
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
