using librarydb_app.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class BooksAuthorsForm : Form
    {
        public BooksAuthorsForm()
        {
            InitializeComponent();
            InitializeData();
            InitializeComboBoxes();
        }

        private void InitializeData()
        {
            var query = from BA in Program.loginForm.DataContext.BookhasauthorSak
                        join author in Program.loginForm.DataContext.AuthorSak on BA.AuthorId equals author.AuthorId
                        join book in Program.loginForm.DataContext.BookSak on BA.BookId equals book.BookId
                        orderby author.LastName
                        select new
                        {
                            book.BookId,
                            author.AuthorId,
                            author.LastName,
                            author.FirstName,
                            author.MiddleName,
                            bookTitle = book.Name
                        };
            dataGridViewBA.DataSource = query.ToList();
        }

        private void InitializeComboBoxes()
        {
            comboBoxAuthors.DataSource = Program.loginForm.DataContext.AuthorSak
                .Select(author => author.LastName + " " + author.FirstName + " " + author.MiddleName).ToList();
            comboBoxBooks.DataSource = Program.loginForm.DataContext.BookSak
                .Select(book => book.Name).ToList();
            comboBoxAuthors.SelectedItem = null;
            comboBoxBooks.SelectedItem = null;
        }

        private void buttonAddBA_Click(object sender, EventArgs e)
        {
            BookhasauthorSak newBA; // новая свзяь книга-автор
            try
            {
                int bookID = Program.loginForm.DataContext.BookSak
                    .FirstOrDefault(book => book.Name
                    .Equals(comboBoxBooks.SelectedItem.ToString())).BookId;
                int authorID = Program.loginForm.DataContext.AuthorSak
                    .FirstOrDefault(author => (author.LastName + " " + author.FirstName + " " + author.MiddleName)
                    .Equals(comboBoxAuthors.SelectedItem.ToString())).AuthorId;

                newBA = new BookhasauthorSak
                {
                    AuthorId = authorID,
                    BookId = bookID
                };

                // чтобы не добавлять связь автор-книга, которая уже существует
                if (Program.loginForm.DataContext.BookhasauthorSak
                    .FirstOrDefault(ba => ba.BookId.Equals(bookID) && ba.AuthorId.Equals(authorID)) == null)
                {
                    Program.loginForm.DataContext.Add(newBA);
                    Program.loginForm.DataContext.SaveChanges();
                }
                else
                    MessageBox.Show("Такая связь автор-книга уже существует");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

            // обновляем источники данных и обновляем таблицу и combobox
            InitializeData();
            InitializeComboBoxes();
            dataGridViewBA.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewBA.SelectedRows)
            {
                int bookId = (int)selectedRow.Cells[0].Value;
                int authorId = (int)selectedRow.Cells[1].Value;
                // ищем элемент для удаления
                var toDelete = Program.loginForm.DataContext.BookhasauthorSak
                    .FirstOrDefault(ba => ba.AuthorId.Equals(authorId) && ba.BookId.Equals(bookId));
                if (toDelete != null)
                {
                    Program.loginForm.DataContext.BookhasauthorSak.Remove(toDelete);
                    Program.loginForm.DataContext.SaveChanges();
                }
            }

            // обновляем источники данных и обновляем таблицу и combobox
            InitializeComboBoxes();
            InitializeData();
            dataGridViewBA.Refresh();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim().ToLower(); // исходная строка без лишних пробелов

            // Проверяем, не является ли значение поисковой строки пустой строкой
            if (string.IsNullOrEmpty(searchValue))
            {
                // Если значение пустое, то сбрасываем видимость всех строк и выходим из метода
                foreach (DataGridViewRow row in dataGridViewBA.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Отображаем только подходящие по поиску строки
            foreach (DataGridViewRow row in dataGridViewBA.Rows)
            {
                dataGridViewBA.CurrentCell = null;

                if (!(row.Cells[0].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[1].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[2].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[3].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[4].Value.ToString().ToLower().Contains(searchValue)
                    || row.Cells[5].Value.ToString().ToLower().Contains(searchValue)
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
            foreach (DataGridViewColumn column in dataGridViewBA.Columns)
            {
                // Добавляем столбец в DataTable
                dataTable.Columns.Add(column.HeaderText);
            }

            // Заполнение DataTable данными из DataGridView
            foreach (DataGridViewRow row in dataGridViewBA.Rows)
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
                .Combine("..\\..\\DbReports", $"BooksAuthors_{DateTime.Now:ddMMyyyy_HHmmss}.xml");
            // Сохранение DataTable в XML файл
            dataTable.WriteXml(fileName);

            MessageBox.Show("Отчёт сохранен.");
        }
    }

}
