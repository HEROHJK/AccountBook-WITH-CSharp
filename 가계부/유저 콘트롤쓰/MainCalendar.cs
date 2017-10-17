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
        public MainCalendar()
        {
            InitializeComponent();

            buttonCalendarMonth.Text = string.Format("{0:0000}년 {1:00}월", Global.year, Global.month);
        }

        private void buttonNextMonth_Click_1(object sender, EventArgs e)
        {
            if (Global.month >= 12)
            {
                Global.month = 1;
                Global.year++;
            }
            else
            {
                Global.month++;
            }
            buttonCalendarMonth.Text = string.Format("{0:0000}년 {1:00}월", Global.year, Global.month);
        }

        private void buttonPreviousMonth_Click_1(object sender, EventArgs e)
        {
            if (Global.month <= 1)
            {
                Global.month = 12;
                Global.year--;
            }
            else
            {
                Global.month--;
            }

            buttonCalendarMonth.Text = string.Format("{0:0000}년 {1:00}월", Global.year, Global.month);
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
            buttonCalendarMonth.Text = string.Format("{0:0000}년 {1:00}월", Global.year, Global.month);
        }
    }
}