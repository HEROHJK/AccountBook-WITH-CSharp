using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class Global
    {
        //시간정보
        public static int year = DateTime.Now.Year;
        public static int month = DateTime.Now.Month;
        public static int day = DateTime.Now.Day;
        public static int hour = DateTime.Now.Hour;
        public static int minute = DateTime.Now.Minute;

        //기준일
        public static int baseDay;

        //DB
        public static DataBaseManagementClass dbmc = new DataBaseManagementClass();

        //프로그램 클래스들
        public static ProgramDateManagementClass pdmc = new ProgramDateManagementClass();

        //계정정보
        public static string userName;
        public static int userId;
        public static decimal amount = 0.0m;

        //통장목록
        public static BankList bankList;

        //카테고리 목록
        public static BigCategoryList categoryList;

        //월별 내역 목록
        public static MonthlyRowList monthlyList;
    }
}
