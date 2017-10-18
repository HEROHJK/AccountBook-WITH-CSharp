using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace 가계부
{
    public partial class MainListItemDay : UserControl
    {
        int lastHour=12;
        int lastMinute=0;
        int year;
        int month;
        int day;
        string dayWeek;

        public MainListItemDay()
        {
            InitializeComponent();
        }

        public MainListItemDay(int year, int month, int day, string inCome, string outCome)
        {
            InitializeComponent();

            this.year = year;
            this.month = month;
            this.day = day;
            DateTime temp = new DateTime(year, month, day);
            CultureInfo cultures = CultureInfo.CreateSpecificCulture("ko-KR");
            dayWeek = temp.ToString(string.Format("ddd요일",cultures));
            labelDay.Text = string.Format("{0:00}",day);
            labelYearMonth.Text = string.Format("{0:0000}.{1:00}", year, month);
            labelDayWeek.Text = dayWeek;
            labelInCome.Text = inCome;
            labelOutCome.Text = outCome;
        }

        private void MainListItemDay_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAddList_Click_1(object sender, EventArgs e)
        {
            Global.pdmc.main.ioForm = new InOutComeForm(year, month, day, lastHour, lastMinute);
            Global.pdmc.main.ioForm.ShowDialog();
        }

        private void MainListItemDay_MouseUp(object sender, MouseEventArgs e)
        {
            buttonAddList.Show();
            Thread hideThread = new Thread(new ThreadStart(HideButton));
            hideThread.Start();
        }

        private void HideButton()
        {
            Thread.Sleep(1000);
            try {
                this.BeginInvoke(
                (ThreadStart)delegate ()
                {
                    buttonAddList.Hide();
                }
                );
            }
            catch { };
        }
    }
}