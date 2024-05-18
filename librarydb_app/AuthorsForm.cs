using librarydb_app.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();
            dataGridViewAuthors.DataSource = Program.loginForm.DataContext.AuthorSak.ToList(); // связали данные с таблицей
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorSak newAuthor = new AuthorSak
                {
                    LastName = textBoxLastName.Text,
                    FirstName = textBoxFirstName.Text,
                    MiddleName = textBoxMiddleName.Text,
                    BirthDate = DateTime.ParseExact(textBoxBirthDate.Text, "dd.MM.yyyy", null).Date,
                    DeathDate = DateTime.ParseExact(textBoxDeathDate.Text, "dd.MM.yyyy", null).Date,
                    AuthorBriefBiography = richTextBoxBiography.Text
                };
                Program.loginForm.DataContext.Add(newAuthor);
                Program.loginForm.DataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

            // обновляем источник данных и обновляем отображение таблицы
            dataGridViewAuthors.DataSource = null;
            dataGridViewAuthors.DataSource = Program.loginForm.DataContext.AuthorSak.ToList();
            dataGridViewAuthors.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewAuthors.SelectedRows)
            {
                int id = (int)selectedRow.Cells[0].Value;
                // ищем элемент для удаления по первичному ключу
                var toDelete = Program.loginForm.DataContext.AuthorSak.FirstOrDefault(author => author.AuthorId.Equals(id));
                if (toDelete != null)
                {
                    Program.loginForm.DataContext.AuthorSak.Remove(toDelete);
                    Program.loginForm.DataContext.SaveChanges();
                }
            }
            // обновляем источник данных и обновляем отображение таблицы
            dataGridViewAuthors.DataSource = null;
            dataGridViewAuthors.DataSource = Program.loginForm.DataContext.AuthorSak.ToList();
            dataGridViewAuthors.Refresh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedAuthor = Program.loginForm.DataContext.AuthorSak.FirstOrDefault(author => author.AuthorId.Equals((int)dataGridViewAuthors.CurrentRow.Cells[0].Value));
            if (selectedAuthor != null)
            {
                MessageBox.Show($"Reader with ReaderID = {selectedAuthor.AuthorId} has edited");
                // изменяем данные читателя
                selectedAuthor.LastName = textBoxLastName.Text;
                selectedAuthor.FirstName = textBoxFirstName.Text;
                selectedAuthor.MiddleName = textBoxMiddleName.Text;
                selectedAuthor.BirthDate = DateTime.ParseExact(textBoxBirthDate.Text, "dd.MM.yyyy", null).Date;
                selectedAuthor.DeathDate = DateTime.ParseExact(textBoxDeathDate.Text, "dd.MM.yyyy", null).Date;
                selectedAuthor.AuthorBriefBiography = richTextBoxBiography.Text;

                // сохраняем изменения и обновляем datagridview
                Program.loginForm.DataContext.SaveChanges();
                dataGridViewAuthors.DataSource = null;
                dataGridViewAuthors.DataSource = Program.loginForm.DataContext.AuthorSak.ToList();
                dataGridViewAuthors.Refresh();
            }

        }

        private void dataGridViewAuthors_SelectionChanged(object sender, EventArgs e)
        {
            // заполняем textbox по выделенной строке
            if (dataGridViewAuthors.CurrentRow != null) // выделенная строка
            {
                textBoxFirstName.Text = dataGridViewAuthors.CurrentRow.Cells[1].Value.ToString();
                textBoxLastName.Text = dataGridViewAuthors.CurrentRow.Cells[2].Value.ToString();
                textBoxMiddleName.Text = dataGridViewAuthors.CurrentRow.Cells[3].Value.ToString();
                textBoxBirthDate.Text = ((DateTime)dataGridViewAuthors.CurrentRow.Cells[4].Value).ToString("dd.MM.yyyy");
                textBoxDeathDate.Text = ((DateTime)dataGridViewAuthors.CurrentRow.Cells[5].Value).ToString("dd.MM.yyyy");
                if (dataGridViewAuthors.CurrentRow.Cells[6].Value != null)
                    richTextBoxBiography.Text = dataGridViewAuthors.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim().ToLower(); // исходная строка без лишних пробелов

            // Проверяем, не является ли значение поисковой строки пустой строкой
            if (string.IsNullOrEmpty(searchValue))
            {
                // Если значение пустое, то сбрасываем видимость всех строк и выходим из метода
                foreach (DataGridViewRow row in dataGridViewAuthors.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Отображаем только подходящие по поиску строки
            foreach (DataGridViewRow row in dataGridViewAuthors.Rows)
            {
                dataGridViewAuthors.CurrentCell = null;

                if (!(row.Cells[0].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[1].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[2].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[3].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[4].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[5].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[6].Value.ToString().ToLower().Contains(searchValue)
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
            foreach (DataGridViewColumn column in dataGridViewAuthors.Columns)
            {
                // Добавляем столбец в DataTable
                dataTable.Columns.Add(column.HeaderText);
            }

            // Заполнение DataTable данными из DataGridView
            foreach (DataGridViewRow row in dataGridViewAuthors.Rows)
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
                .Combine("..\\..\\DbReports", $"AuthorsForm_{DateTime.Now:ddMMyyyy_HHmmss}.xml");
            // Сохранение DataTable в XML файл
            dataTable.WriteXml(fileName);

            MessageBox.Show("Отчёт сохранен.");
        }
    }
}
