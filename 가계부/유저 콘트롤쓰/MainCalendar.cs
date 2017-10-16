using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 가계부
{
    public partial class MainCalendar : UserControl
    {
        public int year;
        public int month;
        public MainCalendar()
        {
            InitializeComponent();
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;

            buttonCalendarMonth.Text = string.Format("{0:0000}년 {1:00}월", year, month);
        }

        private void buttonNextMonth_Click_1(object sender, EventArgs e)
        {
            if (month >= 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
            buttonCalendarMonth.Text = string.Format("{0:0000}년 {1:00}월", year, month);
        }

        private void buttonPreviousMonth_Click_1(object sender, EventArgs e)
        {
            if (month <= 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }

            buttonCalendarMonth.Text = string.Format("{0:0000}년 {1:00}월", year, month);
        }

        private void buttonCalendarMonth_Click_1(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            MainCalendarSelect selectForm = new MainCalendarSelect(this, x, y);
            selectForm.Show();
        }

        public void ChangeDate()
        {
            buttonCalendarMonth.Text = string.Format("{0:0000}년 {1:00}월", year, month);
        }
    }
}