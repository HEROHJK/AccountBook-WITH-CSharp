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
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            bankSettingForm = new BankSettingForm(this, x, y);
            bankSettingForm.Show();
        }

        //분류 설정
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            categorySettingForm = new CategorySettingForm(this);
            categorySettingForm.Show();
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

            LoadData();
        }

        private void LoadData()
        {
            Global.bankList = new BankList();
            Global.bankList.LoadBankList();
            Global.categoryList = new BigCategoryList();
            Global.categoryList.LoadCategoryList();
            int i = 0;
            int y = 0; ;
            while (i < 50)
            {
                y = 0;
                foreach (Control item in panelList.Controls)
                {
                    y += item.Height;
                }
                var temp = new MainListItemDay();
                temp.Location = new Point(temp.Location.X, temp.Location.Y + y);
                panelList.Controls.Add(temp);
                i++;
            }
            panelList.AutoScroll = false;
            panelList.HorizontalScroll.Enabled = false;
            panelList.HorizontalScroll.Visible = false;
            panelList.HorizontalScroll.Maximum = 0;
            panelList.AutoScroll = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ioForm = new InOutComeForm();

            ioForm.ShowDialog();
        }
    }
}