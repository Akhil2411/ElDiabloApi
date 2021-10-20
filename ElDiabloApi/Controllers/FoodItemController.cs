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
    
    [RoutePrefix("api/FoodItem")]
    public class FoodItemController : ApiController
    {
        [HttpGet]
        [Route("getAllFoodItem")]
        public List<ElDiabloFoodItemEntity> GetFoodItem()
        {
           ElDiabloFoodItemService es = new ElDiabloFoodItemService();
            return es.GetFoodItems();
        }


        [HttpGet]
        [Route("getFoodItemById/{id}")]
        public HttpResponseMessage GetFoodItemById(int id)
        {
            ElDiabloFoodItemService es = new ElDiabloFoodItemService();
            var data = es.GetFoodItemById(id);
            if (!data.Any())     
            {
                

                return Request.CreateResponse(HttpStatusCode.NotFound, "FoodItem with Id : " + id.ToString() + " Not Found");

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
        }

        [HttpPost]
        [Route("insertFoodItem")]
        public HttpResponseMessage PostFoodItem([FromBody] ElDiabloFoodItemEntity el)
        {
            ElDiabloFoodItemService es = new ElDiabloFoodItemService();
            var data = es.InsertFoodItem(el);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.Created, "Inserted Successfully.!");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Item already exists");
            }
        }


        [HttpPut]
        [Route("updateFoodItem/{id}")]
        public HttpResponseMessage PutFoodItem(int id, [FromBody] ElDiabloFoodItemEntity el)
        {
            ElDiabloFoodItemService es = new ElDiabloFoodItemService();
            var data = es.UpdateFoodItem(id, el);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Updated Successfully.!");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Employee with id" + id.ToString() + " exists");
            }
        }

        [HttpDelete]
        [Route("deleteFoodItem/{id}")]
        public HttpResponseMessage DeleteFoodItem(int id)
        {
            ElDiabloFoodItemService es = new ElDiabloFoodItemService();
            var data = es.DeleteFoodItem(id);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted Successfully.!");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Employee with id" + id.ToString() + " exists");
            }
        }






    }
}
