using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlSimpleTest
{
    public class MySQLUsersReader
    {
        private string myConnectionString = "server=127.0.0.1;uid=root;pwd=vertrigo;database=my_vk_network;";

        public bool AddUser(User user)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO users (login, password, fio, age, birth_date, email) " +
                        "VALUES (" +
                        $"'{user.Login}', '{user.Password}', '{user.Fio}', '{user.Age}', '{user.BitrhDate.ToString("yyyy-MM-dd")}', '{user.Email}'" +
                        ");";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
            return true;
        }

        public bool DeleteUser(string login)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();
                    string query = $"DELETE FROM users WHERE login = '{login}';";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public List<User> ReadUsers()
        {
            List<User> result = new List<User>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();
                    string query = "SELECT login, password, fio, age, birth_date, email FROM users;";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.Login = reader.GetString("login");
                            user.Password = reader.GetString("password");
                            user.Fio = reader.GetString("fio");
                            user.Age = reader.GetInt32("age");
                            user.BitrhDate = reader.GetDateTime("birth_date");
                            user.Email = reader.GetString("email");
                            result.Add(user);
                        }
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }
            return result;
        }
    }
}
