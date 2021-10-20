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

    [RoutePrefix("api/Sell")]
    public class SellController : ApiController
    {

        [HttpGet]
        [Route("getAllSell")]
        public List<ElDiabloSellEntity> GetOrder()
        {
            ElDiabloSellService es = new ElDiabloSellService();
            return es.GetSells();
        }

        [HttpGet]
        [Route("getSell/{id}")]
        public HttpResponseMessage GetSellById(int id)
        {
            ElDiabloSellService es = new ElDiabloSellService();
            var data = es.GetSellById(id);
            if (!data.Any())
            {


                return Request.CreateResponse(HttpStatusCode.NotFound, "Sell with Id : " + id.ToString() + " Not Found");

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
        }

        [HttpPost]
        [Route("insertSell")]
        public HttpResponseMessage PostSell([FromBody] ElDiabloSellEntity el)
        {
            ElDiabloSellService es = new ElDiabloSellService();
            var data = es.InsertSell(el);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.Created, "Inserted Successfully.!");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Sell already exists");
            }
        }

        [HttpPut]
        [Route("updateSell/{id}")]
        public HttpResponseMessage PutSell(int id, [FromBody] ElDiabloSellEntity el)
        {
            ElDiabloSellService es = new ElDiabloSellService();
            var data = es.UpdateSell(id, el);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Updated Successfully.!");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Sell with id" + id.ToString() + " exists");
            }
        }


        [HttpDelete]
        [Route("deleteSell/{id}")]
        public HttpResponseMessage DeleteSell(int id)
        {
            ElDiabloSellService es = new ElDiabloSellService();
            var data = es.DeleteSell(id);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted Successfully.!");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Sell with id" + id.ToString() + " exists");
            }
        }

    }
}

   