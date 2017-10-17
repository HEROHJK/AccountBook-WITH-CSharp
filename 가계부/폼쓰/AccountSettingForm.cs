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
    public partial class AccountSettingForm : Form
    {
        MainForm main;

        public AccountSettingForm(MainForm main, int x, int y)
        {
            InitializeComponent();

            this.main = main;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountSettingForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountSettingForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = Global.userName;
            textBoxAmount.Text = Global.amount.ToString();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            main.LogOut();
        }
    }
}
