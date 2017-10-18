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
    public partial class BankSettingForm : Form
    {
        MainForm main;

        int realIndex;

        public BankSettingForm(MainForm main, int x, int y)
        {
            InitializeComponent();

            this.main = main;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
            LoadBankList();
        }

        private void buttonAddBank_Click(object sender, EventArgs e)
        {
            if (textBoxNewBank.Text != null && textBoxNewBank.Text != "")
            {
                Bank bank = Global.dbmc.AddBank(textBoxNewBank.Text);

                if (bank != null)
                {
                    Global.bankList.LoadBankList();
                    LoadBankList();
                }
            }
            else
            {
                MessageBox.Show("제대로 입력하셈.");
            }
        }

        private void LoadBankList()
        {
            dataGridViewBanks.Rows.Clear();
            int count = Global.bankList.GetCount();

            int i = 0;
            while (i < count)
            {
                string balance = Global.bankList.GetBank(i).GetBalance().ToString();
                String[] row = {Global.bankList.GetBank(i).GetName(), balance  };
                dataGridViewBanks.Rows.Add(row);
                i++;
            }
        }

        private void dataGridViewBanks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = ((DataGridView)sender).CurrentCellAddress.Y;
            Bank bank=Global.bankList.GetBank(index);

            textBoxBankName.Text = bank.GetName();
            textBoxBalance.Text = bank.GetBalance().ToString();

            realIndex = bank.GetIndex();
        }

        private void buttonNameCorrect_Click(object sender, EventArgs e)
        {
            if (textBoxBankName.Text != null || textBoxBankName.Text != "")
            {
                Global.dbmc.CorrectBankName(realIndex, textBoxBankName.Text);
                Global.bankList.LoadBankList();

                LoadBankList();

                MessageBox.Show("바뀜");
            }
            
        }
    }
}