using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class Global
    {
        public static string userName;
        public static int userId;
        public static decimal amount=0.0m;
        public static int year = DateTime.Now.Year;
        public static int month = DateTime.Now.Month;
        public static DataManagement dm = new DataManagement();
        public static BankList bankList;
        public static BigCategoryList categoryList;
    }
}
