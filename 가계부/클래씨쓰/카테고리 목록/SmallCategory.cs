using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class SmallCategory
    {
        private int index;
        private int parentIndex;
        private string name;

        public SmallCategory(int index, int parentIndex, string name)
        {
            this.index = index;
            this.parentIndex = parentIndex;
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetIndex()
        {
            return this.index;
        }

        public int GetParentIndex()
        {
            return this.parentIndex;
        }
    }
}
