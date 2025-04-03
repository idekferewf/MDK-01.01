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
        private BindingList<User> users_;
             
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
            users_ = new BindingList<User>(mySQLUsersReader_.ReadUsers());
            usersGridView.DataSource = users_;
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
                    users_.Remove(user);

                    // выводим сообщение об успехе
                    MessageBox.Show("Пользователь успешно удалён.", "Успех");
                }
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                // добавляем пользователя в базу данных
                bool isAdded = mySQLUsersReader_.AddUser(addUserForm.user);
                if (isAdded)
                {
                    // выводим сообщения об успехе
                    MessageBox.Show($"Пользователь «{addUserForm.user.Login}» успешно добавлен!", "Успех");

                    // добавляем пользователя в таблицу
                    users_.Add(addUserForm.user);
                }
            }
        }
    }
}
