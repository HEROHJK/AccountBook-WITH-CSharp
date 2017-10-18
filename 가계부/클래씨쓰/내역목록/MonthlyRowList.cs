using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class MonthlyRowList
    {
        List<ViewRow> rowList = new List<ViewRow>();
        int year;
        int month;
        int startDay;//시작일과 종료일은 추후 기준점을 설정할때 쓰이기 위한 용도
        int endDay;

        public MonthlyRowList(int year, int month, int startDay, int endDay)
        {
            this.year = year;
            this.month = month;
            this.startDay = startDay;
            this.endDay = endDay;

            this.rowList.Clear();
        }

        public void LoadViewRows()
        {

        }

        public int GetCount()
        {
            return rowList.Count;
        }

        public ViewRow GetViewRow(int index)
        {
            return rowList[index];
        }

        public int GetYear()
        {
            return year;
        }

        public int GetMonth()
        {
            return month;
        }

        public int GetStartDay()
        {
            return startDay;
        }

        public int GetEndDay()
        {
            return endDay;
        }
    }
}
