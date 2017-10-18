using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class Util
    {
        #region Decimal(통화) 문자열로 바꾸기(소수점 생략)
        public static string WriteMoneyString(Decimal money)
        {
            string moneyString = string.Format("{0:#,##0}", Math.Truncate(money));
            //moneyString = moneyString.Substring(0, moneyString.IndexOf('.'));

            return moneyString;
        }
        #endregion

        #region 문자열 Decimal(통화)로 바꾸기(소수점 생략)
        public static Decimal ReadMoneyDecimal(string money)
        {
            return Convert.ToDecimal(money);
        }
        #endregion

        #region 시간 문자열 -> 숫자로 쪼개기
        public static void DateStringToInt(string dateString, ref int year, ref int month, ref int day, ref int hour, ref int minute)
        {
            year = Convert.ToInt32(dateString.Substring(0, 4));
            month = Convert.ToInt32(dateString.Substring(5, 2));
            day = Convert.ToInt32(dateString.Substring(8, 2));
            try
            {
                hour = Convert.ToInt32(dateString.Substring(11, 2));
                minute = Convert.ToInt32(dateString.Substring(14, 2));
            }
            catch
            {
                DateTime temp = Convert.ToDateTime(dateString);
                hour = temp.Hour;
                minute = temp.Minute;

            }
        }
        #endregion

        #region 시간 문자열에서 날짜만 받아오기
        public static int DateStringToIntDay(string dateString)
        {
            return Convert.ToInt32(dateString.Substring(8, 2));
        }
        #endregion
    }
}
