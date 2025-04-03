using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlSimpleTest
{
    public partial class MainForm: Form
    {
        private MySQLUsersReader mySQLUsersReader_;

        public MainForm()
        {
            InitializeComponent();

            // заполняем таблицу пользователями из базы данных
            mySQLUsersReader_ = new MySQLUsersReader();
            FillUsersFromDatabase();

            // растягиваем последний столбец
            usersGridView.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FillUsersFromDatabase()
        {
            List<User> users = mySQLUsersReader_.ReadUsers();
            usersGridView.DataSource = users;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count > 0)
            {
                // получаем логин пользователя
                User user = usersGridView.SelectedRows[0].DataBoundItem as User;

                // удаляем пользователя
                bool isDeleted = mySQLUsersReader_.DeleteUser(user.Login);
                if (isDeleted)
                {
                    // заполняем заново таблицу
                    FillUsersFromDatabase();

                    // выводим сообщение об успехе
                    MessageBox.Show("Пользователь успешно удалён.", "Успех");
                }
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }
    }
}
