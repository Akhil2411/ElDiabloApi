using ElDiabloEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDiabloDataAccessLayer
{
    public class ElDiabloFoodItemData
    {
        ElDiabloEntities db = new ElDiabloEntities();
              
        public List<ElDiabloFoodItemEntity> GetFoodItems()
        {
            var data =( from item in db.RMSFoodItems
                       select new ElDiabloFoodItemEntity()
                       {
                           ItemId = item.ItemId,
                           ItemCode = item.ItemCode,
                           ItemName = item.ItemName,
                           ItemType = item.ItemType,
                           PricePerItem = item.PricePerItem,
                           TotalStock = item.TotalStock

                       }).ToList();
            return data;
        }

        public List<ElDiabloFoodItemEntity> GetFoodItemsById(int ItemId)
        {
            var data = (from item in db.RMSFoodItems
                        where item.ItemId==ItemId
                        select new ElDiabloFoodItemEntity()
                        {
                            ItemId = item.ItemId,
                            ItemCode = item.ItemCode,
                            ItemName = item.ItemName,
                            ItemType = item.ItemType,
                            PricePerItem = item.PricePerItem,
                            TotalStock = item.TotalStock

                        }).ToList();
            return data;
        }


        public bool InsertFoodItem(ElDiabloFoodItemEntity foodItemEntity)
        {
            try
            {
                if (db.RMSFoodItems.Find(foodItemEntity.ItemId) == null)
                {
                    RMSFoodItem rms = new RMSFoodItem()
                    {
                        ItemId = foodItemEntity.ItemId,
                        ItemCode = foodItemEntity.ItemCode,
                        ItemName = foodItemEntity.ItemName,
                        ItemType = foodItemEntity.ItemType,
                        PricePerItem = foodItemEntity.PricePerItem,
                        TotalStock = foodItemEntity.TotalStock
                    };

                    db.RMSFoodItems.Add(rms);
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


        public bool UpdateFoodItem(int ItemId,ElDiabloFoodItemEntity foodItemEntity)
        {
            try
            {
                if (db.RMSFoodItems.Find(ItemId) == null)
                {
                    return false;
                }
                else
                {
                    var food = db.RMSFoodItems.FirstOrDefault(e => e.ItemId == ItemId);
                    food.ItemCode = foodItemEntity.ItemCode;
                    food.ItemName = foodItemEntity.ItemName;
                    food.ItemType = foodItemEntity.ItemType;
                    food.PricePerItem = foodItemEntity.PricePerItem;
                    food.TotalStock = foodItemEntity.TotalStock;

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


        public bool DeleteFoodItem(int ItemId)
        {
            try
            {
                var data = db.RMSFoodItems.Find(ItemId);
                if (data == null)
                {
                    return false;
                }
                else
                {
                    db.RMSFoodItems.Remove(data);
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
