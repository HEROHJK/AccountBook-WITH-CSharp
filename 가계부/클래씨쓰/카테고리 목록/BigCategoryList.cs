﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가계부
{
    class BigCategoryList
    {
        List<BigCategory> list;

        public BigCategoryList()
        {
            list = Global.dbmc.LoadCategoryList();
        }

        public void LoadCategoryList()
        {
            list = Global.dbmc.LoadCategoryList();
        }

        public BigCategory GetBigCategory(int index)
        {
            return list[index];
        }

        public int GetCount()
        {
            return list.Count;
        }
    }
}
