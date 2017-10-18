using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class ProgramDateManagementClass
    {
        public MainForm main;

        public void AddMoney(int bankIndex, Decimal money, char separation, string insertDate, string memo, string bigCategory, string smallCategory)
        {
            Global.dbmc.AddInOut(bankIndex, money, insertDate, separation, memo, bigCategory, smallCategory);
            Global.amount = Global.dbmc.GetAmount();
            Global.bankList.LoadBankList();
        }

        public void MinusMoney(int inOutIndex)
        {
            Global.dbmc.DeleteInOut(inOutIndex);
            Global.amount = Global.dbmc.GetAmount();
            Global.bankList.LoadBankList();
        }
    }
}
