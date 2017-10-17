using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace 가계부
{
    class DataManagement
    {
        string strConn = "Server=hjknas.asuscomm.com;Port=3333;Database=accountBook;Uid=accountBook;Pwd=school123;";

        public DataManagement()
        {
        }

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
    }
}
