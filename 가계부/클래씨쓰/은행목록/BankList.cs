using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class BankList
    {
        List<Bank> bankList = new List<Bank>();

        public BankList()
        {
            bankList.Clear();
        }

        public void LoadBankList()
        {
            bankList = Global.dbmc.LoadBankList();
        }

        public int GetCount()
        {
            return bankList.Count;
        }

        public Bank GetBank(int index)
        {
            return bankList[index];
        }

        public Bank GetBankToRealIndex(int index)
        {
            Bank retBank = new Bank();

            foreach(Bank bank in bankList)
            {
                if (bank.GetIndex() == index) retBank = bank;
            }

            return retBank;
        }
    }
}
