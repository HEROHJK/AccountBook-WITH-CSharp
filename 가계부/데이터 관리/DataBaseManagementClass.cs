using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace 가계부
{
    class DataBaseManagementClass
    {
        string strConn = "Server=hjknas.asuscomm.com;Port=3333;Database=accountBook;Uid=accountBook;Pwd=school123;";

        public DataBaseManagementClass()
        {
        }
        #region 은행추가
        public Bank AddBank(string name)
        {
            Bank newBank;

            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("INSERT INTO accountBook.`Bank` (name, accountIndex) Values('{0}', '{1}');", name, Global.userId);

                MySqlCommand cmd = new MySqlCommand(query, mysql);

                cmd.ExecuteNonQuery();

                query = string.Format("SELECT `index`, `balance` FROM accountBook.`Bank` a WHERE a.`accountIndex` = '{0}' ORDER BY a.`index` desc LIMIT 1;", Global.userId);

                cmd.CommandText = query;

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                newBank = new Bank(name, Convert.ToInt32(reader[0]), Convert.ToDecimal(reader[1]));
            }

            return newBank;
        }
        #endregion

        #region 은행이름수정
        public void CorrectBankName(int index, string name)
        {
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("UPDATE accountBook.`Bank` b SET `name` = '{0}' WHERE b.`index` = '{1}';", name, index);

                MySqlCommand cmd = new MySqlCommand(query, mysql);

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region 은행목록 로드
        public List<Bank> LoadBankList()
        {
            List<Bank> list = new List<Bank>();
            list.Clear();

            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("SELECT count(*) FROM accountBook.`Bank` a WHERE a.`accountIndex` = '{0}';",Global.userId);

                MySqlCommand cmd = new MySqlCommand(query, mysql);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                int i = 0;
                if (count >= 1)
                {
                    query = string.Format("SELECT `name`, `index`, `balance` FROM accountBook.`Bank` a WHERE a.`accountIndex` = '{0}';",Global.userId);
                    cmd.CommandText = query;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (i < count)
                    {
                        reader.Read();
                        Bank tempBank = new Bank(reader[0].ToString(), Convert.ToInt32(reader[1]), Convert.ToDecimal(reader[2]));
                        list.Add(tempBank);
                        i++;
                    }
                }
            }
                return list;
        }
        #endregion

        #region 로그인
        public bool Login(string name, string password)
        {
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query= string.Format("SELECT count(*) FROM accountBook.`Account` a WHERE a.`name`= '{0}' AND a.password = '{1}';",name,password);
                MySqlCommand cmd = new MySqlCommand(query,mysql);

                int boolean = Convert.ToInt32(cmd.ExecuteScalar());

                if (boolean >= 1)
                {
                    Global.userName = name;
                    query = string.Format("SELECT `index` FROM accountBook.`Account` a WHERE a.`name`= '{0}' AND a.password = '{1}';", name, password);
                    cmd.CommandText = query;
                    Global.userId = Convert.ToInt32(cmd.ExecuteScalar());

                    query = string.Format("SELECT `totalAmount` FROM accountBook.`Account` a WHERE a.`index` = '{0}';", Global.userId);

                    cmd.CommandText = query;

                    Global.amount = Convert.ToDecimal(cmd.ExecuteScalar());
                    return true;
                }
                else return false;
            }
        }
        #endregion

        #region 계정 등록
        public int AddAccount(string name, string password)
        {
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("SELECT count(*) FROM accountBook.`Account` a WHERE a.`name`= '{0}';", name);
                MySqlCommand cmd = new MySqlCommand(query, mysql);

                int boolean = Convert.ToInt32(cmd.ExecuteScalar());

                if (boolean == 0)
                {
                    Global.userName = name;
                    query = string.Format("INSERT INTO accountBook.`Account` (`name`, `password`) VALUES('{0}','{1}');", name, password);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    return 1;
                }
                else return 0;
            }
        }
        #endregion

        #region 소분류 로드
        public List<SmallCategory> LoadChildList(int parentIndex)
        {
            List<SmallCategory> list = new List<SmallCategory>();
            list.Clear();
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                SmallCategory smallCategory;
                string query = string.Format("SELECT `index`,`name` FROM accountBook.`SmallCategory` s WHERE s.`parentIndex` = '{0}';", parentIndex);
                MySqlCommand cmd = new MySqlCommand(query, mysql);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    smallCategory = new SmallCategory(Convert.ToInt32(reader[0]), parentIndex, reader[1].ToString());
                    list.Add(smallCategory);
                }
            }
                return list;
        }
        #endregion

        #region 대분류 로드
        public List<BigCategory> LoadCategoryList()
        {
            List<BigCategory> list = new List<BigCategory>();
            list.Clear();
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                BigCategory bigCategory;
                string query = string.Format("SELECT `index`,`name` FROM accountBook.`BigCategory` b WHERE b.`accountIndex` = '{0}';", Global.userId);
                MySqlCommand cmd = new MySqlCommand(query, mysql);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bigCategory = new BigCategory(Convert.ToInt32(reader[0]), reader[1].ToString(), Global.userId);
                    list.Add(bigCategory);
                }
            }
            return list;
        }
        #endregion

        #region 대분류 등록
        public bool AddBigCategory(string name)
        {
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("SELECT count(*) FROM accountBook.`BigCategory` b WHERE b.`name`= '{0}' AND b.`accountIndex` = '{1}';", name, Global.userId);
                MySqlCommand cmd = new MySqlCommand(query, mysql);

                int boolean = Convert.ToInt32(cmd.ExecuteScalar());

                if (boolean == 0)
                {
                    Global.userName = name;
                    query = string.Format("INSERT INTO accountBook.`BigCategory` (`name`, `accountIndex`) VALUES('{0}','{1}');", name, Global.userId);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    return true;
                }
                else return false;
            }
        }
        #endregion

        #region 소분류 등록
        public bool AddSmallCategory(string name, int parentIndex)
        {
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("SELECT count(*) FROM accountBook.`SmallCategory` s WHERE s.`name`= '{0}' AND s.`parentIndex` = '{1}';", name, parentIndex);
                MySqlCommand cmd = new MySqlCommand(query, mysql);

                int boolean = Convert.ToInt32(cmd.ExecuteScalar());

                if (boolean == 0)
                {
                    Global.userName = name;
                    query = string.Format("INSERT INTO accountBook.`SmallCategory` (`name`, `parentIndex`) VALUES('{0}','{1}');", name, parentIndex);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    return true;
                }
                else return false;
            }
        }
        #endregion

        #region 대분류 삭제
        public void DeleteBigCategory(int index)
        {
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("DELETE FROM accountBook.`SmallCategory` WHERE `parentIndex` = '{0}';", index);
                MySqlCommand cmd = new MySqlCommand(query, mysql);

                cmd.ExecuteNonQuery();

                query = string.Format("DELETE FROM accountBook.`BigCategory` WHERE `index` = '{0}';", index);

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region 소분류 삭제
        public void DeleteSmallCategory(int parentIndex, string name)
        {
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("DELETE FROM accountBook.`SmallCategory` WHERE `name` = '{0}' AND `parentIndex` = '{1}';", name, parentIndex);

                MySqlCommand cmd = new MySqlCommand(query, mysql);

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region 내역 등록
        public void AddInOut(int bankIndex, Decimal money, string insertDate, char separation, string memo, string bigCategory, string smallCategory)
        {
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("CALL AddMoney('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');",Global.userId,bankIndex,money.ToString(),insertDate,separation,memo,bigCategory,smallCategory);
                MySqlCommand cmd = new MySqlCommand(query, mysql);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region 내역 삭제
        public void DeleteInOut(int inOutIndex)
        {
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("CALL MinusMoney('{0}');", inOutIndex);
                MySqlCommand cmd = new MySqlCommand(query, mysql);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region 총자산 받아오기
        public Decimal GetAmount()
        {
            using (MySqlConnection mysql = new MySqlConnection(strConn))
            {
                mysql.Open();
                string query = string.Format("SELECT `totalAmount` FROM accountBook.`Account` WHERE accountBook.`Account`.`index` = {0}", Global.userId);
                MySqlCommand cmd = new MySqlCommand(query, mysql);
                cmd.CommandText = query;
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
        #endregion

        #region 내역들 받아오기

        #endregion
    }
}