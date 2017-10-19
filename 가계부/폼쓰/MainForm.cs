using System;
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
    public partial class MainForm : Form
    {
        public LoginForm loginForm;
        public BankSettingForm bankSettingForm;
        public AccountSettingForm accountSettingForm;
        public CategorySettingForm categorySettingForm;
        public InOutComeForm ioForm;

        public MainForm()
        {
            InitializeComponent();

            Global.pdmc.main = this;
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            settingMenu.Show(new Point(x,y));
        }

        public void LogOut()
        {
            accountSettingForm.Close();

            Properties.Settings.Default.autoLogin = false;
            Properties.Settings.Default.id = "";
            Properties.Settings.Default.password = "";
            Global.userName = "";
            Properties.Settings.Default.Save();

            this.Visible = false;

            loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (Global.userName == null || Global.userName == "") this.Close();

            this.Visible = true;
            LoadData();
        }
        
        //계정 설정
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            accountSettingForm = new AccountSettingForm(this,x,y);
            accountSettingForm.Show();
        }

        //통장 설정
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bankSettingForm = new BankSettingForm(this);
            bankSettingForm.ShowDialog();
        }

        //분류 설정
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            categorySettingForm = new CategorySettingForm(this);
            categorySettingForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataBaseManagementClass dm = new DataBaseManagementClass();
            loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (Global.userName == null || Global.userName == "")
            {
                this.Close();
                return;
            }

            panelList.AutoScroll = false;
            panelList.HorizontalScroll.Enabled = false;
            panelList.HorizontalScroll.Visible = false;
            panelList.HorizontalScroll.Maximum = 0;
            panelList.AutoScroll = true;

            LoadData();
        }

        public void LoadData()
        {
            //은행목록 로딩
            Global.bankList = new BankList();
            Global.bankList.LoadBankList();

            //카테고리목록 로딩
            Global.categoryList = new BigCategoryList();
            Global.categoryList.LoadCategoryList();

            //해당 월의 내역들 로딩
            ReLoadRowList();
        }

        public void ReLoadRowList()
        {
            panelList.Controls.Clear();

            Global.monthlyList = new MonthlyRowList(Global.year, Global.month);
            int day = 31;
            int i = 0;
            int count = Global.monthlyList.GetCount();
            int height = 0;
            bool dateFirstRow = true;
            int year, month;
            string date;

            Decimal inCome=0m, outCome=0m;
            Decimal dayInCome, dayOutCome;

            while (i < count && day > 0)
            {
                height = -5;
                foreach (Control item in panelList.Controls)
                {
                    height += item.Height;
                }
                if (day == Global.monthlyList.GetViewRow(i).GetDay())
                {
                    if (dateFirstRow)
                    {
                        var line = new Line();
                        line.Location = new Point(line.Location.X, line.Location.Y + height);
                        panelList.Controls.Add(line);
                        height += 5;
                        year = Global.monthlyList.GetYear();
                        month = Global.monthlyList.GetMonth();
                        date = string.Format("{0:0000}-{1:00}-{2:00}", year, month, day);
                        dayInCome=Global.dbmc.GetDayMoney(date, true);
                        dayOutCome=Global.dbmc.GetDayMoney(date, false);

                        inCome += dayInCome;
                        outCome += dayOutCome;

                        var temp = new MainListItemDay(Global.monthlyList.GetYear(), Global.monthlyList.GetMonth(), day, Util.WriteMoneyString(dayInCome), Util.WriteMoneyString(dayOutCome));
                        temp.Location = new Point(temp.Location.X, temp.Location.Y + height);
                        panelList.Controls.Add(temp);
                        height += 50;
                        dateFirstRow = false;
                    }
                    var rowTemp = Global.monthlyList.GetViewRow(i);
                    var panelItem = new MainListItem(rowTemp.GetBankIndex(), rowTemp.GetInComeIndex(), rowTemp.GetYear(), rowTemp.GetMonth(), rowTemp.GetDay(), rowTemp.GetHour(), rowTemp.GetMinute(), rowTemp.GetBigCategory(), rowTemp.GetSmallCategory(), rowTemp.GetMemo(), rowTemp.GetMoney(), rowTemp.GetSepartion());
                    panelItem.Location = new Point(panelItem.Location.X, panelItem.Location.Y + height);
                    panelList.Controls.Add(panelItem);

                    i++;
                }
                else
                {
                    dateFirstRow = true;
                    day--;
                }

            }

            //수입/합계/지출 등록

            labelInCome.Text = Util.WriteMoneyString(inCome) + " 원";
            labelOutCome.Text = Util.WriteMoneyString(outCome) + " 원";
            labelTotal.Text = Util.WriteMoneyString(inCome - outCome) + " 원";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ioForm = new InOutComeForm();

            ioForm.ShowDialog();
        }

        public void NewIncomeForm(int year, int month, int day, int hour, int minute)
        {
            ioForm = new InOutComeForm(year, month, day, hour, minute);

            ioForm.ShowDialog();
        }
    }
}