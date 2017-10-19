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

        int realIndex=-1;

        bool msgboxOpen = false;

        public BankSettingForm(MainForm main)
        {
            InitializeComponent();

            this.main = main;
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
                    textBoxNewBank.Text = "";
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
                string balance = Util.WriteMoneyString(Global.bankList.GetBank(i).GetBalance())+" 원";
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
            textBoxBalance.Text = Util.WriteMoneyString(bank.GetBalance()) + " 원";

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

        private void buttonBankDelete_Click(object sender, EventArgs e)
        {
            msgboxOpen = true;
            if(realIndex==-1)
            {
                MessageBox.Show("지우려는 통장이 없는디요?", "헐 ㅋ");
                msgboxOpen = false;
                this.Size = new Size(448, 345);
                return;
            }
            if(MessageBox.Show("통장을 지우면여\n거래내역도 지워저여\nㄱㅊ??", "실화냐", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Global.pdmc.DeleteBank(realIndex);
                LoadBankList();
                msgboxOpen = false;
                this.Size = new Size(448, 345);
            }

        }

        private void buttonBankDelete_MouseLeave(object sender, EventArgs e)
        {
            if (!msgboxOpen)
            {
                this.Size = new Size(448, 345);
            }
        }

        private void buttonBankDelete_MouseHover(object sender, EventArgs e)
        {
            this.Size = new Size(748, 345);
        }

        private void BankSettingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}