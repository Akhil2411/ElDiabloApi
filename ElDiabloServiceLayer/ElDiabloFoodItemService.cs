using ElDiabloDataAccessLayer;
using ElDiabloEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDiabloServiceLayer
{
    public class ElDiabloFoodItemService
    {
        public List<ElDiabloFoodItemEntity> GetFoodItems()
        {
            ElDiabloFoodItemData el = new ElDiabloFoodItemData();
            return el.GetFoodItems();
        }

        public List<ElDiabloFoodItemEntity> GetFoodItemById(int id)
        {
            ElDiabloFoodItemData el = new ElDiabloFoodItemData();
            return el.GetFoodItemsById(id);
        }

        public bool InsertFoodItem(ElDiabloFoodItemEntity foodItemEntity)
        {
            ElDiabloFoodItemData el = new ElDiabloFoodItemData();
            return el.InsertFoodItem(foodItemEntity);

        }

        public bool UpdateFoodItem(int id,ElDiabloFoodItemEntity foodItemEntity)
        {
            ElDiabloFoodItemData el = new ElDiabloFoodItemData();
            return el.UpdateFoodItem(id,foodItemEntity);

        }

        public bool DeleteFoodItem(int id)
        {
            ElDiabloFoodItemData el = new ElDiabloFoodItemData();
            return el.DeleteFoodItem(id);

        }


    }
}
