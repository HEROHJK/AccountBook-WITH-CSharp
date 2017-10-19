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
        string startDate;//시작일과 종료일은 추후 기준점을 설정할때 쓰이기 위한 용도
        string endDate;

        public MonthlyRowList(int year, int month)
        {
            this.year = year;
            this.month = month;

            this.startDate = string.Format("{0:0000}-{1:00}-{2:00} 00:00:00",this.year,this.month,Global.baseDay);

            if (month == 12)//12월이면 다음해로
            {
                year++;
                month = 1;
            }
            else month++;

            this.endDate = string.Format("{0:0000}-{1:00}-{2:00} 00:00:00",year,month,Global.baseDay);

            LoadViewRows();
        }

        public void LoadViewRows()
        {
            this.rowList.Clear();
            rowList = Global.dbmc.LoadMonthlyViewRowList(startDate,endDate);
        }

        public string GetLastTime(int month,int day)
        {
            string time="";
            foreach(ViewRow row in rowList)
            {
                if(row.GetMonth()==month && row.GetDay() == day)
                {
                    time = string.Format("{0:00}{1:00}",row.GetHour(), row.GetMinute());
                    break;
                }
            }

            return time;
        }

        public int GetCount()
        {
            return rowList.Count;
        }

        public ViewRow GetViewRow(int index)
        {
            return rowList[index];
        }

        public ViewRow GetViewRowToRealIndex(int index)
        {
            ViewRow ret = new ViewRow();
            foreach(ViewRow row in rowList)
            {
                if (row.GetInComeIndex() == index) return row;
            }

            return ret;
        }

        public int GetYear()
        {
            return year;
        }

        public int GetMonth()
        {
            return month;
        }

        public int GetYear(int index)
        {
            return rowList[index].GetYear();
        }

        public int GetMonth(int index)
        {
            return rowList[index].GetMonth();
        }

        public string GetStartDate()
        {
            return startDate;
        }

        public string GetEndDate()
        {
            return endDate;
        }
    }
}
