using librarydb_app.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class ReadersForm : Form
    {
        public ReadersForm()
        {
            InitializeComponent();
            dataGridViewReaders.DataSource = Program.loginForm.DataContext.ReaderSak.OrderBy(r => r.LastName).ToList(); // источник данных - все читатели
            // Добавляем в combobox логины тех User, у которых ещё нет ID в Reader (User не привязан к Reader)
            comboBoxLogin.DataSource = Program.loginForm.DataContext.UserSak
                .Where(user => user.Role.Equals("reader")
                 && !Program.loginForm.DataContext.ReaderSak.OrderBy(r => r.LastName).Select(reader => reader.UserId).Contains(user.Id))
                .Select(user => user.Login).ToList();

        }

        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            ReaderSak newReader;
            try
            {
                // заполняем свойства новой записи
                newReader = new ReaderSak
                {
                    LastName = textBoxLastName.Text,
                    FirstName = textBoxFirstName.Text,
                    MiddleName = textBoxMiddleName.Text,
                    NumberOfBookLoans = 0,
                    BirthDate = DateTime.ParseExact(textBoxBirthDate.Text, "dd.MM.yyyy", null).Date,
                    HomeAddress = textBoxHomeAddress.Text,
                    PhoneNumber = textBoxPhoneNumber.Text,
                    // по логину определяем ID этого User
                    UserId = Program.loginForm.DataContext.UserSak.SingleOrDefault(user => user.Login == comboBoxLogin.SelectedItem.ToString()).Id
                };
                Program.loginForm.DataContext.Add(newReader);
                Program.loginForm.DataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }


            // обновляем источники данных и обновляем таблицу и combobox
            dataGridViewReaders.DataSource = null;
            dataGridViewReaders.DataSource = Program.loginForm.DataContext.ReaderSak.ToList();
            dataGridViewReaders.Refresh();

            comboBoxLogin.DataSource = null;
            // Добавляем в combobox логины тех User, у которых ещё нет ID в Reader (User не привязан к Reader)
            comboBoxLogin.DataSource = Program.loginForm.DataContext.UserSak
                .Where(user => user.Role.Equals("reader")
                && !Program.loginForm.DataContext.ReaderSak.OrderBy(r => r.LastName)
                .Select(reader => reader.UserId).Contains(user.Id)).Select(user => user.Login).ToList();
            comboBoxLogin.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewReaders.SelectedRows)
            {
                int id = (int)selectedRow.Cells[0].Value;
                // ищем элемент для удаления по первичному ключу
                var toDelete = Program.loginForm.DataContext.ReaderSak.FirstOrDefault(reader => reader.ReaderId.Equals(id));
                if (toDelete != null)
                {
                    Program.loginForm.DataContext.ReaderSak.Remove(toDelete);
                    Program.loginForm.DataContext.SaveChanges();
                }
            }

            // обновляем источники данных и обновляем таблицу и combobox
            dataGridViewReaders.DataSource = null;
            dataGridViewReaders.DataSource = Program.loginForm.DataContext.ReaderSak.ToList();
            dataGridViewReaders.Refresh();

            comboBoxLogin.DataSource = null;
            // Добавляем в combobox логины тех User, у которых ещё нет ID в Reader (User не привязан к Reader)
            comboBoxLogin.DataSource = Program.loginForm.DataContext.UserSak
                .Where(user => user.Role.Equals("reader")
                && !Program.loginForm.DataContext.ReaderSak.OrderBy(r => r.LastName)
                .Select(reader => reader.UserId).Contains(user.Id)).Select(user => user.Login).ToList();
            comboBoxLogin.Refresh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedReader = Program.loginForm.DataContext.ReaderSak.FirstOrDefault(reader => reader.ReaderId.Equals((int)dataGridViewReaders.CurrentRow.Cells[0].Value));
            if (selectedReader != null)
            {
                MessageBox.Show($"Reader with ReaderID = {selectedReader.ReaderId} has edited");

                // изменяем данные читателя
                selectedReader.LastName = textBoxLastName.Text;
                selectedReader.FirstName = textBoxFirstName.Text;
                selectedReader.MiddleName = textBoxMiddleName.Text;
                selectedReader.BirthDate = DateTime.ParseExact(textBoxBirthDate.Text, "dd.MM.yyyy", null).Date;
                selectedReader.HomeAddress = textBoxHomeAddress.Text;
                selectedReader.PhoneNumber = textBoxPhoneNumber.Text;

                // сохраняем изменения и обновляем datagridview
                Program.loginForm.DataContext.SaveChanges();
                dataGridViewReaders.DataSource = null;
                dataGridViewReaders.DataSource = Program.loginForm.DataContext.ReaderSak.OrderBy(r => r.LastName).ToList();
                dataGridViewReaders.Refresh();
            }
        }

        // event выделение строки
        private void dataGridViewReaders_SelectionChanged(object sender, EventArgs e)
        {
            // заполняем textbox по выделенной строке
            if (dataGridViewReaders.CurrentRow != null) // выделенная строка
            {
                textBoxFirstName.Text = dataGridViewReaders.CurrentRow.Cells[1].Value.ToString();
                textBoxLastName.Text = dataGridViewReaders.CurrentRow.Cells[2].Value.ToString();
                textBoxMiddleName.Text = dataGridViewReaders.CurrentRow.Cells[3].Value.ToString();
                textBoxBirthDate.Text = ((DateTime)dataGridViewReaders.CurrentRow.Cells[5].Value).ToString("dd.MM.yyyy");
                textBoxHomeAddress.Text = dataGridViewReaders.CurrentRow.Cells[6].Value.ToString();
                textBoxPhoneNumber.Text = dataGridViewReaders.CurrentRow.Cells[7].Value.ToString();
                comboBoxLogin.SelectedItem = null;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim().ToLower(); // исходная строка без лишних пробелов

            // Проверяем, не является ли значение поисковой строки пустой строкой
            if (string.IsNullOrEmpty(searchValue))
            {
                // Если значение пустое, то сбрасываем видимость всех строк и выходим из метода
                foreach (DataGridViewRow row in dataGridViewReaders.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Отображаем только подходящие по поиску строки
            foreach (DataGridViewRow row in dataGridViewReaders.Rows)
            {
                dataGridViewReaders.CurrentCell = null;

                if (!(row.Cells[0].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[1].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[2].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[3].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[4].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[5].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[6].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[7].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[8].Value.ToString().ToLower().Contains(searchValue)
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
            foreach (DataGridViewColumn column in dataGridViewReaders.Columns)
            {
                // Добавляем столбец в DataTable
                dataTable.Columns.Add(column.HeaderText);
            }

            // Заполнение DataTable данными из DataGridView
            foreach (DataGridViewRow row in dataGridViewReaders.Rows)
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
                .Combine("..\\..\\DbReports", $"Readers_{DateTime.Now:ddMMyyyy_HHmmss}.xml");
            // Сохранение DataTable в XML файл
            dataTable.WriteXml(fileName);

            MessageBox.Show("Отчёт сохранен.");
        }
    }
}
