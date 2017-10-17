using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class BigCategory
    {
        int index;
        string name;
        int accountIndex;
        List<SmallCategory> childList;

        public BigCategory(int index, string name, int accountIndex)
        {
            this.index = index;
            this.name = name;
            this.accountIndex = accountIndex;
            childList = Global.dm.LoadChildList(index);
        }

        public int GetIndex()
        {
            return this.index;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAccountIndex()
        {
            return this.accountIndex;
        }

        public SmallCategory GetChild(int index)
        {
            return childList[index];
        }

        public int GetSmallCategoryCount()
        {
            return childList.Count;
        }
    }
}