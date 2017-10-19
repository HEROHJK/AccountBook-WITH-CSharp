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
        int changeBaseDay;
        bool changed = false;

        public AccountSettingForm(MainForm main, int x, int y)
        {
            InitializeComponent();

            this.main = main;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (changeBaseDay != Global.baseDay)
            {
                changed = true;
                string msg = string.Format("기준일을 변경하겠슴둥? \n\n현재 : {0}일\n변경 : {1}일", Global.baseDay, changeBaseDay);
                DialogResult result = MessageBox.Show(msg, "기준일 변경", MessageBoxButtons.OKCancel);
                if (DialogResult.OK == result)
                {
                    Global.pdmc.ChangeBaseDay(changeBaseDay);
                }
                changed = false;
            }
            this.Close();
        }

        private void AccountSettingForm_Deactivate(object sender, EventArgs e)
        {
            if(!changed) this.Close();
        }

        private void AccountSettingForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = Global.userName;
            textBoxAmount.Text = Util.WriteMoneyString(Global.amount) + " 원";
            comboBoxBaseDay.SelectedIndex = Global.baseDay - 1;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            main.LogOut();
        }

        private void comboBoxBaseDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeBaseDay = Convert.ToInt32(comboBoxBaseDay.Text);
        }
    }
}
