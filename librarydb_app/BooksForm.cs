using librarydb_app.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            InitializeData();
            InitializeComboBoxes();
        }

        private void InitializeData()
        {
            var query = from book in Program.loginForm.DataContext.BookSak
                        join dep in Program.loginForm.DataContext.BookdepartmentSak on book.BookDepartmentId equals dep.DepId
                        join house in Program.loginForm.DataContext.PublishinghouseSak on book.PublishingHouseId equals house.PublishingHouseId
                        select new
                        {
                            book.BookId,
                            dep.DepName,
                            house = house.Name,
                            book.Name,
                            book.Price,
                            book.ReceiptDate,
                            book.InventoryNumber
                        };
            dataGridViewBooks.DataSource = query.ToList();

        }

        private void InitializeComboBoxes()
        {
            comboBoxDepName.DataSource = Program.loginForm.DataContext.BookdepartmentSak.Select(dep => dep.DepName).ToList();
            comboBoxHouseName.DataSource = Program.loginForm.DataContext.PublishinghouseSak.Select(house => house.Name).ToList();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            BookSak newBook;
            try
            {
                int BookDepID = Program.loginForm.DataContext.BookdepartmentSak
                    .SingleOrDefault(dep => dep.DepName.Equals(comboBoxDepName.SelectedItem.ToString())).DepId;
                int HouseID = Program.loginForm.DataContext.PublishinghouseSak
                    .SingleOrDefault(house => house.Name.Equals(comboBoxHouseName.SelectedItem.ToString())).PublishingHouseId;
                newBook = new BookSak
                {
                    BookDepartmentId = BookDepID,
                    PublishingHouseId = HouseID,
                    Name = textBoxBookName.Text,
                    Price = int.Parse(textBoxBookPrice.Text),
                    ReceiptDate = DateTime.ParseExact(textBoxReceiptDate.Text, "dd.MM.yyyy", null).Date,
                };
                Program.loginForm.DataContext.Add(newBook);
                Program.loginForm.DataContext.SaveChanges();
                newBook.InventoryNumber = int.Parse(BookDepID.ToString() + HouseID + newBook.BookId); // задали уникальный инвентарный номер
                Program.loginForm.DataContext.SaveChanges(); // снова сохранили запись уже с инвентарным номером
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // обновляем источники данных и обновляем таблицу и combobox
            InitializeData();
            dataGridViewBooks.Refresh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedBook = Program.loginForm.DataContext.BookSak
                .FirstOrDefault(book => book.BookId.Equals((int)dataGridViewBooks.CurrentRow.Cells[0].Value));
            if (selectedBook != null)
            {
                MessageBox.Show($"Reader with ReaderID = {selectedBook.BookId} has edited");

                int BookDepID = Program.loginForm.DataContext.BookdepartmentSak
                    .SingleOrDefault(dep => dep.DepName.Equals(comboBoxDepName.SelectedItem.ToString())).DepId;
                int HouseID = Program.loginForm.DataContext.PublishinghouseSak
                    .SingleOrDefault(house => house.Name.Equals(comboBoxHouseName.SelectedItem.ToString())).PublishingHouseId;

                // изменяем данные читателя
                selectedBook.BookDepartmentId = BookDepID;
                selectedBook.PublishingHouseId = HouseID;
                selectedBook.Name = textBoxBookName.Text;
                selectedBook.Price = int.Parse(textBoxBookPrice.Text);
                selectedBook.ReceiptDate = DateTime.ParseExact(textBoxReceiptDate.Text, "dd.MM.yyyy", null).Date;
                selectedBook.InventoryNumber = int.Parse(BookDepID.ToString() + HouseID + selectedBook.BookId); // задали уникальный инвентарный номер
                // сохраняем изменения и обновляем datagridview
                Program.loginForm.DataContext.SaveChanges();
                InitializeData();
                dataGridViewBooks.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewBooks.SelectedRows)
            {
                int id = (int)selectedRow.Cells[0].Value;
                // ищем элемент для удаления по первичному ключу
                var toDelete = Program.loginForm.DataContext.BookSak.FirstOrDefault(book => book.BookId.Equals(id));
                if (toDelete != null)
                {
                    Program.loginForm.DataContext.BookSak.Remove(toDelete);
                    Program.loginForm.DataContext.SaveChanges();
                }
            }

            // обновляем источники данных и обновляем таблицу и combobox
            InitializeData();
            dataGridViewBooks.Refresh();
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            // заполняем textbox по выделенной строке
            if (dataGridViewBooks.CurrentRow != null) // выделенная строка
            {
                comboBoxDepName.SelectedItem = dataGridViewBooks.CurrentRow.Cells[1].Value;
                comboBoxHouseName.SelectedItem = dataGridViewBooks.CurrentRow.Cells[2].Value;
                textBoxBookName.Text = dataGridViewBooks.CurrentRow.Cells[3].Value.ToString();
                textBoxBookPrice.Text = dataGridViewBooks.CurrentRow.Cells[4].Value.ToString();
                textBoxReceiptDate.Text = ((DateTime)dataGridViewBooks.CurrentRow.Cells[5].Value).ToString("dd.MM.yyyy");
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim().ToLower(); // исходная строка без лишних пробелов

            // Проверяем, не является ли значение поисковой строки пустой строкой
            if (string.IsNullOrEmpty(searchValue))
            {
                // Если значение пустое, то сбрасываем видимость всех строк и выходим из метода
                foreach (DataGridViewRow row in dataGridViewBooks.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Отображаем только подходящие по поиску строки
            foreach (DataGridViewRow row in dataGridViewBooks.Rows)
            {
                dataGridViewBooks.CurrentCell = null;

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
            foreach (DataGridViewColumn column in dataGridViewBooks.Columns)
            {
                // Добавляем столбец в DataTable
                dataTable.Columns.Add(column.HeaderText);
            }

            // Заполнение DataTable данными из DataGridView
            foreach (DataGridViewRow row in dataGridViewBooks.Rows)
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
                .Combine("..\\..\\DbReports", $"Books_{DateTime.Now:ddMMyyyy_HHmmss}.xml");
            // Сохранение DataTable в XML файл
            dataTable.WriteXml(fileName);

            MessageBox.Show("Отчёт сохранен.");
        }
    }
}
