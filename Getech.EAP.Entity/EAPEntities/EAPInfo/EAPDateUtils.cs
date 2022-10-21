using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.Info
{
    public class EAPDateUtils
    {
        const string TimeFormat1 = "yyyyMMddHHmmssfff";
        const string TimeFormat2 = "yyyy/MM/dd HH:mm:ss";

        private static string getRandomNum()
        {
            Random rd = new Random();
            Thread.Sleep(5);
            return rd.Next(0, 100).ToString();
        }

        public static string getTransactionId()
        {
            string trid = DateTime.Now.ToString(TimeFormat1) + getRandomNum();
            return trid;
        }

        public static string getHistoryTime()
        {
            return DateTime.Now.ToString(TimeFormat2);
        }

        public static string getDateTime(string timeFormat)
        {
            return DateTime.Now.ToString(timeFormat);
        }
    }
}
