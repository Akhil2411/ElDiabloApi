using ElDiabloEntityLayer;
using ElDiabloServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElDiabloApi.Controllers
{

    [RoutePrefix("api/Orders")]
    public class OrderController : ApiController
    {


        [HttpGet]
        [Route("getAllOrders")]
        public List<ElDiabloOrderEntity> GetOrder()
        {
            ElDiabloOrderService es = new ElDiabloOrderService();
            return es.GetOrders();
        }


        [HttpGet]
        [Route("getOrderById/{id}")]
        public HttpResponseMessage GetorderById(int id)
        {
            ElDiabloOrderService es = new ElDiabloOrderService();
            var data = es.GetOrderById(id);
            if (!data.Any())
            {


                return Request.CreateResponse(HttpStatusCode.NotFound, "Order with Id : " + id.ToString() + " Not Found");

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
        }


        [HttpPost]
        [Route("insertOrder")]
        public HttpResponseMessage PostOrderItem([FromBody] ElDiabloOrderEntity el)
        {
            ElDiabloOrderService es = new ElDiabloOrderService();
            var data = es.InsertOrder(el);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.Created, "Inserted Successfully.!");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Order already exists");
            }
        }


        [HttpPut]
        [Route("updateOrder/{id}")]
        public HttpResponseMessage PutOrder(int id, [FromBody] ElDiabloOrderEntity el)
        {
            ElDiabloOrderService es = new ElDiabloOrderService();
            var data = es.UpdateOrder(id, el);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Updated Successfully.!");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Order with id" + id.ToString() + " does not exists");
            }
        }


        [HttpDelete]
        [Route("deleteOrder/{id}")]
        public HttpResponseMessage DeleteOrder(int id)
        {
            ElDiabloOrderService es = new ElDiabloOrderService();
            var data = es.DeleteOrder(id);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted Successfully.!");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Order with id" + id.ToString() + " exists");
            }
        }

    }
}
