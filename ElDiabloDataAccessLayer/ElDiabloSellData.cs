using ElDiabloEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDiabloDataAccessLayer
{
    public class ElDiabloSellData
    {
        ElDiabloEntities db = new ElDiabloEntities();

        public List<ElDiabloSellEntity> GetSells()
        {
            var data = (from item in db.RMSSells
                        select new ElDiabloSellEntity()
                        {
                            SellId = item.SellId,
                            ItemName = item.ItemName,
                            PricePerUnit = item.PricePerUnit,
                            TotalCost = item.TotalCost,
                            OrderId = item.OrderId,
                            ItemId=item.ItemId


                        }).ToList();
            return data;
        }

        public List<ElDiabloSellEntity> GetSellById(int SellId)
        {
            var data = (from item in db.RMSSells
                        where item.SellId == SellId
                        select new ElDiabloSellEntity()
                        {

                            SellId = item.SellId,
                            ItemName = item.ItemName,
                            PricePerUnit = item.PricePerUnit,
                            TotalCost = item.TotalCost,
                            OrderId = item.OrderId,
                            ItemId = item.ItemId

                        }).ToList();
            return data;
        }


        public bool InsertSell(ElDiabloSellEntity sellEntity)
        {
            try
            {
                if (db.RMSFoodItems.Find(sellEntity.SellId) == null)
                {
                    RMSSell rms = new RMSSell()
                    {
                       

                        SellId = sellEntity.SellId,
                        ItemName = sellEntity.ItemName,
                        PricePerUnit = sellEntity.PricePerUnit,
                        TotalCost = sellEntity.TotalCost,
                        OrderId = sellEntity.OrderId,
                        ItemId = sellEntity.ItemId
                    };

                    db.RMSSells.Add(rms);
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


        public bool UpdateSell(int SellId, ElDiabloSellEntity sellEntity)
        {
            try
            {
                if (db.RMSSells.Find(SellId) == null)
                {
                    return false;
                }
                else
                {
                    var sell = db.RMSSells.FirstOrDefault(e => e.SellId == SellId);



                    sell.SellId = sellEntity.SellId;
                    sell.ItemName = sellEntity.ItemName;
                    sell.PricePerUnit = sellEntity.PricePerUnit;
                    sell.TotalCost = sellEntity.TotalCost;
                    sell.OrderId = sellEntity.OrderId;
                    sell.ItemId = sellEntity.ItemId;

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


        public bool DeleteSell(int SellId)
        {
            try
            {
                var data = db.RMSSells.Find(SellId);
                if (data == null)
                {
                    return false;
                }
                else
                {
                    db.RMSSells.Remove(data);
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