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
    }
}
