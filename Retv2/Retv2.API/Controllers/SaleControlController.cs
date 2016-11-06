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
    public class SaleControlController : ApiController
    {
        protected IRestaurantBusinessObject BusinessObject;
        public SaleControlController(IBusinessObjectService service)
        {
            BusinessObject = service.GetBusinessObject();
        }
        // GET: api/SaleControl
        public async Task<HttpResponseMessage> Get()
        {
            var response = new ComposedResponse<SaleControlViewModel>();

            try
            {
                response.Model = await Task.Run(() =>
                {

                    return BusinessObject.GetSaleControls().Select(item => (new SaleControlViewModel(item)));

                });
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // GET: api/SaleControl/5
        public async Task<HttpResponseMessage> Get(int id)
        {
            var response = new SingleResponse<SaleControlViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.GetSaleControl(new SaleControl(id));
                });
                response.Model = new SaleControlViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

        // POST: api/SaleControl
        public async Task<HttpResponseMessage> Post([FromBody]SaleControl value)
        {
            var response = new SingleResponse<SaleControlViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.CreateSaleControl(value);
                });
                response.Model = new SaleControlViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // PUT: api/SaleControl/5
        public async Task<HttpResponseMessage> Put(int id, [FromBody]SaleControl value)
        {
            var response = new SingleResponse<SaleControlViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.UpdateSaleControl(value);
                });
                response.Model = new SaleControlViewModel(entity);
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // DELETE: api/SaleControl/5
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var response = new SingleResponse<SaleControlViewModel>();
            try
            {
                var entity = await Task.Run(() =>
                {
                    return BusinessObject.DeleteSaleControl(new SaleControl(id));
                });
                response.Model = new SaleControlViewModel(entity);
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
