using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlSimpleTest
{
    public class MySQLUsersReader
    {
        public List<User> ReadUsers()
        {
            List<User> result = new List<User>();

            string myConnectionString = "server=127.0.0.1;uid=root;pwd=vertrigo;database=my_vk_network;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();

                    const string query = "SELECT login, password, fio, age, birth_date, email FROM users;";
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
