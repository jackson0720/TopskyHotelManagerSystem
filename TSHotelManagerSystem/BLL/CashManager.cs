using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.BLL
{
   public class CashManager
    {
        public static List<Cash> SelectCashInfoAll()
        {

            return CashService.SelectCashInfoAll();
        }
<<<<<<< HEAD
=======

        public static object AddCashInfo(Models.Cash cash)
        {
            return CashService.AddCashInfo(cash);
        }
>>>>>>> 40311c0... 更新源码2020-04-19
    }
}
