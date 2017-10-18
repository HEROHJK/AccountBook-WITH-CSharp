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
    public partial class CategorySettingForm : Form
    {
        MainForm main;
        int lastCategoryIndex = 0;
        public CategorySettingForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            LoadCategory();
        }

        #region 대분류 등록
        private void buttonAddBig_Click(object sender, EventArgs e)
        {
            if (TextBoxValidate())
            {
                if (Global.dbmc.AddBigCategory(textBoxCategoryName.Text))
                {
                    LoadCategory();
                }
                else
                {
                    MessageBox.Show("중복");
                }
            }
        }
        #endregion

        #region 소분류 등록
        private void buttonAddSmall_Click(object sender, EventArgs e)
        {
            if (TextBoxValidate())
            {
                int parentIndex = Global.categoryList.GetBigCategory(comboBoxBigCategory.SelectedIndex).GetIndex();
                if (Global.dbmc.AddSmallCategory(textBoxCategoryName.Text,parentIndex))
                {
                    LoadCategory();
                }
                else
                {
                    MessageBox.Show("중복");
                }
            }
        }
        #endregion

        #region 대분류 삭제
        private void buttonBigDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxBigCategory.Items.Count > 0)
            {
                int realIndex = Global.categoryList.GetBigCategory(comboBoxBigCategory.SelectedIndex).GetIndex();
                Global.dbmc.DeleteBigCategory(realIndex);
                lastCategoryIndex = 0;
                LoadCategory();
            }

        }
        #endregion

        #region 소분류 삭제
        private void buttonSmallDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxBigCategory.Items.Count > 0 && Global.categoryList.GetBigCategory(comboBoxBigCategory.SelectedIndex).GetSmallCategoryCount()>0)
            {
                int realIndex = Global.categoryList.GetBigCategory(comboBoxBigCategory.SelectedIndex).GetIndex();
                Global.dbmc.DeleteSmallCategory(realIndex, dataGridViewSmallCategory.Rows[((DataGridView)sender).CurrentCellAddress.Y].Cells[((DataGridView)sender).CurrentCellAddress.X].Value.ToString());
                lastCategoryIndex = 0;
                LoadCategory();
            }
        }
        #endregion

        #region 카테고리 로드,리로드
        private void LoadCategory()
        {
            comboBoxBigCategory.Items.Clear();
            dataGridViewSmallCategory.Rows.Clear();
            textBoxCategoryName.Text = "";
            Global.categoryList = new BigCategoryList();
            Global.categoryList.LoadCategoryList();

            String[] data;

            int count = Global.categoryList.GetCount();

            data = new String[count];

            int i = 0;

            while (i < count)
            {
                data[i] = Global.categoryList.GetBigCategory(i).GetName();
                i++;
            }

            comboBoxBigCategory.Items.AddRange(data);

            if(comboBoxBigCategory.Items.Count>0)
            {
                comboBoxBigCategory.SelectedIndex = lastCategoryIndex;
            }

        }
        #endregion

        #region 소분류 로드
        private void LoadSmallCategory()
        {
            int index = comboBoxBigCategory.SelectedIndex;

            int count = Global.categoryList.GetBigCategory(index).GetSmallCategoryCount();

            int i = 0;

            while (i < count)
            {
                string name = Global.categoryList.GetBigCategory(index).GetChild(i).GetName();
                dataGridViewSmallCategory.Rows.Add(name);

                i++;
            }
            
        }
        #endregion

        private void comboBoxBigCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSmallCategory();
            lastCategoryIndex = comboBoxBigCategory.SelectedIndex;
        }

        private bool TextBoxValidate()
        {
            if(textBoxCategoryName.Text==null || textBoxCategoryName.Text == "")
            {
                MessageBox.Show("제대로 입력하셈");
                return false;
            }

            return true;
        }
    }
}