using ElDiabloDataAccessLayer;
using ElDiabloEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDiabloServiceLayer
{
    public class ElDiabloOrderService
    {
        public List<ElDiabloOrderEntity> GetOrders()
        {
            ElDiabloOrderData el = new ElDiabloOrderData();
            return el.GetOrders();
        }

        public List<ElDiabloOrderEntity> GetOrderById(int id)
        {
            ElDiabloOrderData el = new ElDiabloOrderData();
            return el.GetOrderById(id);
        }

        public bool InsertOrder(ElDiabloOrderEntity orderEntity)
        {
            ElDiabloOrderData el = new ElDiabloOrderData();
            return el.InsertOrder(orderEntity);

        }

        public bool UpdateOrder(int id, ElDiabloOrderEntity orderEntity)
        {
            ElDiabloOrderData el = new ElDiabloOrderData();
            return el.UpdateOrder(id, orderEntity);

        }

        public bool DeleteOrder(int id)
        {
            ElDiabloOrderData el = new ElDiabloOrderData();
            return el.DeleteOrder(id);

        }


    }
}

