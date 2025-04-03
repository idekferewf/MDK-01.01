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
    public partial class AddUserForm : Form
    {
        public User user { get; set; }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            // создаём экземпляр пользователя
            user = new User();
            user.Login = loginTextBox.Text;
            user.Password = passwordTextBox.Text;
            user.Fio = fioTextBox.Text;
            user.Age = (int)ageNumericUpDown.Value;
            user.BitrhDate = birthDateTimePicker.Value;
            user.Email = emailTextBox.Text;

            // валидируем пользователя
            if (string.IsNullOrEmpty(user.Login) ||
                string.IsNullOrEmpty(user.Password) ||
                string.IsNullOrEmpty(user.Fio) ||
                user.Age <= 0 ||
                user.BitrhDate > DateTime.Now)
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
