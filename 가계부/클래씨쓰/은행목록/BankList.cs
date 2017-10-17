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
            bankList = Global.dm.LoadBankList();
        }

        public int GetCount()
        {
            return bankList.Count;
        }

        public Bank GetBank(int index)
        {
            return bankList[index];
        }
    }
}
