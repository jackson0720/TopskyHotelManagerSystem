﻿using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class SpendManager
    {
        public static int InsertSpendInfo(Spend s)
        {
            return SpendService.InsertSpendInfo(s);
        }

        public static List<Spend> SelectSpendByCustoNo(string No)
        {
            return SpendService.SelectSpendByCustoNo(No);
        }

        public static List<Spend> SelectSpendInfoAll()
        {
            return SpendService.SelectSpendInfoAll();
        }

        /// <summary>
        /// 根据房间号查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        public static List<Spend> SelectSpendInfoRoomNo(string RoomNo)
        {
            return SpendService.SelectSpendInfoRoomNo(RoomNo);
        }

        #region 根据房间编号、入住时间到当前时间查询消费总金额
        /// <summary>
        /// 根据房间编号、入住时间到当前时间查询消费总金额
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="custono"></param>
        /// <returns></returns>
        public static object SelectMoneyByRoomNoAndTime(string roomno,string custono)
        {
            return SpendService.SelectMoneyByRoomNoAndTime(roomno, custono);
        }
        #endregion

        #region 根据房间编号、入住时间和当前时间修改结算状态
        /// <summary>
        /// 根据房间编号、入住时间和当前时间修改结算状态
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="checktime"></param>
        /// <returns></returns>
        public static int UpdateMoneyState(string roomno, string checktime)
        {
            return SpendService.UpdateMoneyState(roomno, checktime);
        }
        #endregion

    }
}
