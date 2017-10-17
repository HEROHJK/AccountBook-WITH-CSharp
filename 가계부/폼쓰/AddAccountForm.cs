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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount();
        }

        private void AddAccount()
        {
            if (textBoxID.Text == null || textBoxID.Text == "")
            {
                MessageBox.Show("이름이 없자나 ㅡㅡ");
                return;
            }
            if (textBoxPASS.Text == null || textBoxPASS.Text == "")
            {
                MessageBox.Show("비번이 없자나 ㅡㅡ");
                return;
            }
            if (Global.dm.AddAccount(textBoxID.Text, textBoxPASS.Text) == 0)
            {
                MessageBox.Show("이미있는 아이디자나 ㅡㅡ");
                return;
            }

            MessageBox.Show("축하해 등록됬어!");
            this.Close();
        }

        private void AddAccountForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxID.Text.Length > 0 && textBoxPASS.Text.Length > 0)
                {
                    AddAccount();
                }
            }
            else if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
