using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class Bank
    {
        string name;
        int index;
        decimal balance;
        int number;

        public Bank()
        {
            name = "";
            index= 0;
            balance = 0.0M;
        }

        public Bank(string name, int index, decimal balance)
        {
            this.name = name;
            this.index = index;
            this.balance = balance;
        }

        public decimal LoadBank(int index, int accountId)
        {

            return this.balance;
        }

        public string AddBank(string name, int accountId)
        {

            return this.name;
        }

        public decimal AddMoney(decimal money)
        {
            this.balance += money;

            return this.balance;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetIndex()
        {
            return this.index;
        }

        public decimal GetBalance()
        {
            return this.balance;
        }
    }
}
