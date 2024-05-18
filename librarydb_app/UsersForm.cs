using librarydb_app.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            dataGridViewUsers.DataSource = Program.loginForm.DataContext.UserSak.ToList();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedItem == null || textBoxLogin.Text.Equals(string.Empty) || textBoxPassword.Text.Equals(string.Empty))
            {
                MessageBox.Show("Поля не заполнены");
                return;
            }

            try
            {
                UserSak newUser = new UserSak
                {
                    Login = textBoxLogin.Text,
                    Password = textBoxPassword.Text,
                    Role = comboBoxRole.SelectedItem.ToString()
                };

                Program.loginForm.DataContext.Add(newUser);
                Program.loginForm.DataContext.SaveChanges();

                // обновляем источник данных и обновляем отображение таблицы
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = Program.loginForm.DataContext.UserSak.ToList();
                dataGridViewUsers.Refresh();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewUsers.SelectedRows)
            {
                int id = (int)selectedRow.Cells[0].Value;
                // ищем элемент для удаления по первичному ключу
                var toDelete = Program.loginForm.DataContext.UserSak.FirstOrDefault(user => user.Id.Equals(id));
                if (toDelete != null)
                {
                    Program.loginForm.DataContext.UserSak.Remove(toDelete);
                    Program.loginForm.DataContext.SaveChanges();
                }
            }
            // обновляем источник данных и обновляем отображение таблицы
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = Program.loginForm.DataContext.UserSak.ToList();
            dataGridViewUsers.Refresh();
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow != null) // выделенная строка
            {
                textBoxLogin.Text = dataGridViewUsers.CurrentRow.Cells[1].Value.ToString();
                textBoxPassword.Text = dataGridViewUsers.CurrentRow.Cells[2].Value.ToString();
                comboBoxRole.SelectedItem = dataGridViewUsers.CurrentRow.Cells[3].Value;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedUser = Program.loginForm.DataContext.UserSak.FirstOrDefault(user => user.Id.Equals((int)dataGridViewUsers.CurrentRow.Cells[0].Value));
            if (selectedUser != null)
            {
                MessageBox.Show($"User with ID = {selectedUser.Id} has edited");

                selectedUser.Login = textBoxLogin.Text;
                selectedUser.Password = textBoxPassword.Text;
                selectedUser.Role = comboBoxRole.SelectedItem.ToString();

                // сохраняем изменения и обновляем datagridview
                Program.loginForm.DataContext.SaveChanges();
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = Program.loginForm.DataContext.UserSak.ToList();
                dataGridViewUsers.Refresh();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim().ToLower(); // исходная строка без лишних пробелов

            // Проверяем, не является ли значение поисковой строки пустой строкой
            if (string.IsNullOrEmpty(searchValue))
            {
                // Если значение пустое, то сбрасываем видимость всех строк и выходим из метода
                foreach (DataGridViewRow row in dataGridViewUsers.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Отображаем только подходящие по поиску строки
            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                dataGridViewUsers.CurrentCell = null;

                if (!(row.Cells[0].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[1].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[2].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[3].Value.ToString().ToLower().Contains(searchValue)
                    ))
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void buttonCreateXML_Click(object sender, EventArgs e)
        {
            // Создание нового DataTable
            DataTable dataTable = new DataTable("MyDataTable");

            // Добавление столбцов в DataTable
            foreach (DataGridViewColumn column in dataGridViewUsers.Columns)
            {
                // Добавляем столбец в DataTable
                dataTable.Columns.Add(column.HeaderText);
            }

            // Заполнение DataTable данными из DataGridView
            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                // Проверяем, что строка видимая
                if (row.Visible)
                {
                    // Создаем новую строку для DataTable
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Заполняем значение ячейки в строке DataTable
                        dataRow[cell.OwningColumn.HeaderText] = cell.Value;
                    }
                    // Добавляем заполненную строку в DataTable
                    dataTable.Rows.Add(dataRow);
                }
            }

            // Формирование названия файла
            string fileName = Path
                .Combine("..\\..\\DbReports", $"Users_{DateTime.Now:ddMMyyyy_HHmmss}.xml");
            // Сохранение DataTable в XML файл
            dataTable.WriteXml(fileName);

            MessageBox.Show("Отчёт сохранен.");
        }
    }
}
