using librarydb_app.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class LoginForm : Form
    {
        public string Login;
        public string UserRole;
        public int UserId;
        public Data.librarydbContext DataContext;
        public LoginForm()
        {
            InitializeComponent();
            textBoxLogin.Text = "admin1";
            textBoxPassword.Text = "admin";
            DataContext = new Data.librarydbContext();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login = textBoxLogin.Text;
            UserSak result = DataContext.UserSak.FirstOrDefault(user => user.Login.Equals(textBoxLogin.Text) &&
                user.Password.Equals(textBoxPassword.Text));
            if (result == null)
            {
                MessageBox.Show("Пользователь не найден.");
            }
            else if (result.Role.Equals("admin"))
            {
                this.Hide();
                Program.adminForm.Show();
            }
            else if (result.Role.Equals("reader"))
            {
                this.Hide();
                Program.regularForm.labelLogin.Text = "Текущий пользователь: " + Login;
                Program.regularForm.Show();
            }
            else
            {
                MessageBox.Show("Роль пользователя не подходит.");
            }
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }
    }
}
