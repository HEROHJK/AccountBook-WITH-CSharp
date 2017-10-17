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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if(textBoxID.Text==null || textBoxID.Text=="" || textBoxPASS.Text == null || textBoxPASS.Text == "")
            {
                MessageBox.Show("정보를 입력하셈.");
                return;
            }
            if (Global.dm.Login(textBoxID.Text, textBoxPASS.Text))
            {
                if (checkBox1.Checked)
                {
                    Properties.Settings.Default.autoLogin = true;
                    Properties.Settings.Default.id = textBoxID.Text;
                    Properties.Settings.Default.password = textBoxPASS.Text;
                }
                else
                {
                    Properties.Settings.Default.autoLogin = false;
                    Properties.Settings.Default.id = "";
                    Properties.Settings.Default.password = "";
                }
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.autoLogin)
            {
                checkBox1.Checked = true;
                textBoxID.Text = Properties.Settings.Default.id;
                textBoxPASS.Text = Properties.Settings.Default.password;
                Login();
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            AddAccountForm addForm = new AddAccountForm();

            addForm.ShowDialog();
        }
    }
}
