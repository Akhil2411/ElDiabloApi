using ElDiabloDataAccessLayer;
using ElDiabloEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDiabloServiceLayer
{
    public class ElDiabloSellService
    {

        public List<ElDiabloSellEntity> GetSells()
        {
            ElDiabloSellData el = new ElDiabloSellData();
            return el.GetSells();
        }

        public List<ElDiabloSellEntity> GetSellById(int id)
        {
            ElDiabloSellData el = new ElDiabloSellData();
            return el.GetSellById(id);
        }

        public bool InsertSell(ElDiabloSellEntity sellEntity)
        {
            ElDiabloSellData el = new ElDiabloSellData();
            return el.InsertSell(sellEntity);

        }

        public bool UpdateSell(int id, ElDiabloSellEntity sellEntity)
        {
            ElDiabloSellData el = new ElDiabloSellData();
            return el.UpdateSell(id, sellEntity);

        }

        public bool DeleteSell(int id)
        {
            ElDiabloSellData el = new ElDiabloSellData();
            return el.DeleteSell(id);

        }


    }
}

