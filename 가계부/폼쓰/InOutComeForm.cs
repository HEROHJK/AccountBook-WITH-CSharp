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
    public partial class InOutComeForm : Form
    {
        int bankIndex;
        Decimal money;
        string insertDate;
        string memo;
        string bigCategory, smallCategory;
        char separation;

        public InOutComeForm()
        {
            InitializeComponent();
        }

        private void buttonSelectBank_Click(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            bankMenu.Show(new Point(x, y));
        }

        private void buttonSelectCategory_Click(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            categoryMenu.Show(new Point(x, y));
        }

        private void InOutComeForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            int j;
            int count, subCount;
            //메뉴 추가 -> 은행들
            count = Global.bankList.GetCount();
            while (i < count)
            {
                bankMenu.Items.Add((i+1)+". "+Global.bankList.GetBank(i).GetName(),null,BankClick);
                i++;
            }

            i = 0;
            count = Global.categoryList.GetCount();
            while (i < count)
            {
                categoryMenu.Items.Add(Global.categoryList.GetBigCategory(i).GetName(),null,CategoryClick);

                j = 0;
                subCount = Global.categoryList.GetBigCategory(i).GetSmallCategoryCount();
                while(j<subCount)
                {
                    (categoryMenu.Items[i] as ToolStripMenuItem).DropDownItems.Add(Global.categoryList.GetBigCategory(i).GetName() + "/"+Global.categoryList.GetBigCategory(i).GetChild(j).GetName(),null,SmallCategoryClick);
                    j++;
                }
                
                i++;
            }

        }

        private void BankClick(object sender, EventArgs e)
        {
            string temp= ((ToolStripItem)sender).Text;
            int dotIndex = temp.IndexOf('.');
            bankIndex = Global.bankList.GetBank(Convert.ToInt32(temp.Substring(0, dotIndex))-1).GetIndex();
            textBoxBank.Text = temp.Substring(dotIndex + 2);
        }

        private void CategoryClick(object sender, EventArgs e)
        {
            bigCategory = ((ToolStripItem)sender).Text;
            smallCategory = null;
            textBoxCategory.Text= bigCategory;
        }

        private void SmallCategoryClick(object sender, EventArgs e)
        {
            string temp = ((ToolStripItem)sender).Text;
            int index = temp.IndexOf('/');
            bigCategory = temp.Substring(0, index) ;
            smallCategory = temp.Substring(index+1);
            textBoxCategory.Text = temp;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxBank.Text==null || textBoxBank.Text == "")
            {
                MessageBox.Show("은행을 선택하시요");
                return;
            }
            else if(textBoxCategory.Text==null || textBoxCategory.Text == "")
            {
                MessageBox.Show("분류를 선택하십숑");
                return;
            }
            else if(textBoxMoney.Text==null || textBoxMoney.Text == "")
            {
                MessageBox.Show("얼마인지 쓰십쑈", "이거 안쓸꺼면 이거 왜씀?ㅡㅡ");
                return;
            }
            if (!MoneyCheck(textBoxMoney.Text))
            {
                MessageBox.Show("돈을 올바르게 기입하십쑈", "내가 이런거까지 신경써줘야되?");
                return;
            }

            money = Convert.ToDecimal(textBoxMoney.Text);
            memo = textBoxMemo.Text;
            insertDate = string.Format("{0:0000}-{1:00}-{2:00} {3:00}:{4:00}:{5:00}",dateTime.Value.Year,dateTime.Value.Month,dateTime.Value.Day,dateTime.Value.Hour,dateTime.Value.Minute,dateTime.Value.Second);

            if (radioButton1.Checked) separation = 'I';
            else separation = 'O';

            Global.pdmc.AddMoney(bankIndex, money, separation, insertDate, memo, bigCategory, smallCategory);

            this.Close();

        }

        private bool MoneyCheck(string money)
        {
            if (money[0] == '-' && money.Length == 1) return false;

            return true;
        }

        private void textBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46) //8:백스페이스,45:마이너스,46:소수점
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 45 && !MinusCheck())//마이너스는 맨 앞에 하나만 들어올수 있음
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 46 && !DotCheck())//소수점은 하나만, 숫자 앞에만 찍힐수 있음
            {
                e.Handled = true;
            }
        }

        private bool MinusCheck()
        {
            if (textBoxMoney.Text.Length < 1) return true;
            else return false;
        }

        private bool DotCheck()
        {
            string str = textBoxMoney.Text;
            int dotCount = 0;
            int i = 0;
            int length = str.Length;
            while (i < length && dotCount<1)
            {
                if (str[i] == '.')
                {
                    dotCount++;
                }
                i++;
            }

            if (length == 0) return false;//길이가 0이면 맨앞에 도트를 찍는다는 뜻이라서 false반환
            else if (length==1 && str[length-1]=='-') return false;//길이가1인데 맨앞이 '-' 이라면 이것도 숫자가 아니게 되므로 false반환
            else if (dotCount > 0) return false;//소수점이 이미 찍혀있으면 false반환
            else return true;//그외에는 true반환
        }

        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
