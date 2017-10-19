using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class ProgramDataManagementClass
    {
        public MainForm main;

        public void AddMoney(int bankIndex, Decimal money, char separation, string insertDate, string memo, string bigCategory, string smallCategory)
        {
            Global.dbmc.AddInOut(bankIndex, money, insertDate, separation, memo, bigCategory, smallCategory);
            Global.amount = Global.dbmc.GetAmount();

            Global.bankList = new BankList();
            Global.bankList.LoadBankList();

            this.main.ReLoadRowList();
        }

        public void MinusMoney(int inOutIndex)
        {
            Global.dbmc.DeleteInOut(inOutIndex);
            Global.amount = Global.dbmc.GetAmount();

            Global.bankList = new BankList();
            Global.bankList.LoadBankList();

            this.main.ReLoadRowList();
        }

        public void ChangeBaseDay(int baseDay)
        {
            Global.dbmc.ChangeBaseDay(baseDay);

            Global.baseDay = baseDay;

            main.ReLoadRowList();
        }

        public void DeleteBank(int bankIndex)
        {
            Global.dbmc.DeleteBank(bankIndex);

            main.LoadData();
        }
    }
}
