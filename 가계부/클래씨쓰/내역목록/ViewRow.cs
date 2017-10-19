using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class ViewRow
    {
        int inComeIndex;
        char separation;
        Decimal money;
        string memo;
        int bankIndex;
        int year, month, day, hour, minute;
        string bigCategory;
        string smallCategory;

        public ViewRow(int inComeIndex, char separation, Decimal money, string memo, int bankIndex, int year, int month, int day, int hour, int minute, string bigCategory, string smallCategory)
        {
            this.inComeIndex = inComeIndex;
            this.separation = separation;
            this.money = money;
            this.memo = memo;
            this.bankIndex = bankIndex;
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
            this.bigCategory = bigCategory;
            this.smallCategory = smallCategory;
        }

        public ViewRow()
        {

        }

        public int GetInComeIndex()
        {
            return this.inComeIndex;
        }

        public char GetSepartion()
        {
            return this.separation;
        }

        public Decimal GetMoney()
        {
            return this.money;
        }

        public string GetMemo()
        {
            return this.memo;
        }

        public int GetBankIndex()
        {
            return this.bankIndex;
        }

        public int GetYear()
        {
            return this.year;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public int GetDay()
        {
            return this.day;
        }

        public int GetHour()
        {
            return this.hour;
        }

        public int GetMinute()
        {
            return this.minute;
        }

        public string GetBigCategory()
        {
            return this.bigCategory;
        }

        public string GetSmallCategory()
        {
            return this.smallCategory;
        }

    }
}
