﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 가계부
{
    public partial class MainCalendarSelect : Form
    {
        MainCalendar main;

        public MainCalendarSelect(MainCalendar main, int x, int y)
        {
            InitializeComponent();
            this.main = main;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);

            labelYear.Text = Global.year.ToString();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNowMonth_Click(object sender, EventArgs e)
        {
            Global.year = DateTime.Now.Year;
            Global.month = DateTime.Now.Month;

            this.Close();
        }

        private void button1Month_Click(object sender, EventArgs e)
        {
            Global.month = 1;
            this.Close();
        }

        private void button2Month_Click(object sender, EventArgs e)
        {
            Global.month = 2;
            this.Close();
        }

        private void button3Month_Click(object sender, EventArgs e)
        {
            Global.month = 3;
            this.Close();
        }

        private void button4Month_Click(object sender, EventArgs e)
        {
            Global.month = 4;
            this.Close();
        }

        private void button5Month_Click(object sender, EventArgs e)
        {
            Global.month = 5;
            this.Close();
        }

        private void button6Month_Click(object sender, EventArgs e)
        {
            Global.month = 6;
            this.Close();
        }

        private void button7Month_Click(object sender, EventArgs e)
        {
            Global.month = 7;
            this.Close();
        }

        private void button8Month_Click(object sender, EventArgs e)
        {
            Global.month = 8;
            this.Close();
        }

        private void button9Month_Click(object sender, EventArgs e)
        {
            Global.month = 9;
            this.Close();
        }

        private void button10Month_Click(object sender, EventArgs e)
        {
            Global.month = 10;
            this.Close();
        }

        private void button11Month_Click(object sender, EventArgs e)
        {
            Global.month = 11;
            this.Close();
        }

        private void button12Month_Click(object sender, EventArgs e)
        {
            Global.month = 12;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Global.year;
            year--;
            labelYear.Text = year.ToString();
            Global.year = year;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int year = Global.year;
            year++;
            labelYear.Text = year.ToString();
            Global.year = year;
        }

        private void MainCalendarSelect_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainCalendarSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.ChangeDate();
        }
    }
}
