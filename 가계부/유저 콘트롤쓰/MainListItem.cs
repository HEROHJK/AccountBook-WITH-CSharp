using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 가계부
{
    public partial class MainListItem : UserControl
    {
        int bankIndex;
        int inOutIndex;
        int year;
        int month;
        int day;
        int hour;
        int minute;
        string bigCategory;
        string smallCategory;
        string memo;
        char separation;
        Decimal money;

        public MainListItem(int bankIndex, int inOutIndex, int year, int month, int day, int hour, int minute, string bigCategory, string smallCategory, string memo, Decimal money, char separation)
        {
            InitializeComponent();

            //일단 값들을 다 받는다
            this.bankIndex = bankIndex;
            this.inOutIndex = inOutIndex;
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
            this.bigCategory = bigCategory;
            this.smallCategory = smallCategory;
            this.memo = memo;
            this.money = money;
            this.separation = separation;

            //메모가 비어있으면 분류를 메모로 복사
            if (this.memo == "")
            {
                this.memo = this.bigCategory;
                if (this.smallCategory != "")
                {
                    this.memo += " / " + this.smallCategory;
                }
            }

            //그리고 등ㅋ넉ㅋ
            labelBigCategory.Text = this.bigCategory;
            labelSmallCategory.Text = this.smallCategory;
            labelMemo.Text = this.memo;
            labelTime.Text = string.Format("{0:00}:{1:00}", this.hour, this.minute);
            labelBank.Text = Global.bankList.GetBankToRealIndex(this.bankIndex).GetName();
            labelMoney.Text = Util.WriteMoneyString(this.money);
            //수익일떄는 초록색
            if (this.separation == 'I')
            {
                labelMoney.ForeColor = Color.Green;
                label1.ForeColor = Color.Green;
            }
            //지출일때는 빨간색
            else
            {
                labelMoney.ForeColor = Color.Red;
                label1.ForeColor = Color.Red;
            }
        }

        private void ControlClick(object sender, EventArgs e)
        {

        }
    }
}
