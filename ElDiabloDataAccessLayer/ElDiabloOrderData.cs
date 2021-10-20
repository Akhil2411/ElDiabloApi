using ElDiabloEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ElDiabloDataAccessLayer
{
   public class ElDiabloOrderData
    {
        ElDiabloEntities db = new ElDiabloEntities();

        public List<ElDiabloOrderEntity> GetOrders()
        {
            var data = (from item in db.RMSOrders
                        select new ElDiabloOrderEntity()
                        {
                            OrderId = item.OrderId,
                            CustomerName = item.CustomerName,
                            ContactNumber = item.ContactNumber,
                            OrderDate = item.OrderDate,
                            OrderAmount = item.OrderAmount
                           

                        }).ToList();
            return data;
        }

        public List<ElDiabloOrderEntity> GetOrderById(int OrderId)
        {
            var data = (from item in db.RMSOrders
                        where item.OrderId == OrderId
                        select new ElDiabloOrderEntity()
                        {

                            OrderId = item.OrderId,
                            CustomerName = item.CustomerName,
                            ContactNumber = item.ContactNumber,
                            OrderDate = item.OrderDate,
                            OrderAmount = item.OrderAmount

                        }).ToList();
            return data;
        }


        public bool InsertOrder(ElDiabloOrderEntity orderEntity)
        {
            try
            {
                if (db.RMSFoodItems.Find(orderEntity.OrderId) == null)
                {
                    RMSOrder rms = new RMSOrder()
                    {
                        OrderId = orderEntity.OrderId,
                        CustomerName = orderEntity.CustomerName,
                        ContactNumber = orderEntity.ContactNumber,
                        OrderDate = orderEntity.OrderDate,
                        OrderAmount = orderEntity.OrderAmount
                    };

                    db.RMSOrders.Add(rms);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }


        public bool UpdateOrder(int OrderId, ElDiabloOrderEntity orderEntity)
        {
            try
            {
                if (db.RMSOrders.Find(OrderId) == null)
                {
                    return false;
                }
                else
                {
                    var ord = db.RMSOrders.FirstOrDefault(e => e.OrderId == OrderId);
                  

                    ord.OrderId = orderEntity.OrderId;
                    ord.CustomerName = orderEntity.CustomerName;
                    ord.ContactNumber = orderEntity.ContactNumber;
                    ord.OrderDate = orderEntity.OrderDate;
                    ord.OrderAmount = orderEntity.OrderAmount;

                    db.SaveChanges();
                    return true;



                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }


        }


        public bool DeleteOrder(int OrderId)
        {
            try
            {
                var data = db.RMSOrders.Find(OrderId);
                if (data == null)
                {
                    return false;
                }
                else
                {
                    db.RMSOrders.Remove(data);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }

        }


    }
}
