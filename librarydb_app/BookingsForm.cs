using librarydb_app.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class BookingsForm : Form
    {
        public BookingsForm()
        {
            InitializeComponent();
            InitializeData();
            InitializeComboBoxes();
        }

        private void InitializeData()
        {
            var query = from booking in Program.loginForm.DataContext.BookingSak
                        join dep in Program.loginForm.DataContext.BookdepartmentSak on booking.DepId equals dep.DepId
                        join reader in Program.loginForm.DataContext.ReaderSak on booking.ReaderId equals reader.ReaderId
                        join book in Program.loginForm.DataContext.BookSak on booking.BookId equals book.BookId
                        orderby reader.LastName
                        select new
                        {
                            BookingID = booking.BookingId,
                            Department = dep.DepName,
                            Reader = reader.LastName + reader.FirstName,
                            Book = book.Name,
                            booking.LoanDate,
                            booking.ReturnDate
                        };
            dataGridViewBookings.DataSource = query.ToList();
        }

        private void InitializeComboBoxes()
        {
            comboBoxDepName.DataSource = Program.loginForm.DataContext.BookdepartmentSak.Select(dep => dep.DepName).ToList();
            comboBoxReader.DataSource = Program.loginForm.DataContext.ReaderSak.OrderBy(r => r.LastName)
                .Select(reader => reader.LastName + reader.FirstName).ToList();
            // только те книги из конкретного отдела, которые ещё не выданы
            comboBoxBook.DataSource = Program.loginForm.DataContext.BookSak.Where(book => book.BookDepartmentId == Program.loginForm.DataContext.BookdepartmentSak
                 .FirstOrDefault(dep => dep.DepName.Equals(comboBoxDepName.SelectedItem.ToString())).DepId &&
                 !Program.loginForm.DataContext.BookingSak.Select(booking => booking.BookId).Contains(book.BookId))
                .Select(book => book.Name).ToList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedBooking = Program.loginForm.DataContext.BookingSak
                .FirstOrDefault(booking => booking.BookingId.Equals((int)dataGridViewBookings.CurrentRow.Cells[0].Value));
            if (selectedBooking != null)
            {
                MessageBox.Show($"Reader with ReaderID = {selectedBooking.BookId} has edited");

                int BookDepID = Program.loginForm.DataContext.BookdepartmentSak
                    .SingleOrDefault(dep => dep.DepName.Equals(comboBoxDepName.SelectedItem.ToString())).DepId;
                int ReaderID = Program.loginForm.DataContext.ReaderSak
                    .SingleOrDefault(reader => (reader.LastName + reader.FirstName)
                    .Equals(comboBoxReader.SelectedItem.ToString())).ReaderId;
                int BookID;
                if (comboBoxBook.SelectedItem != null)
                {
                    BookID = Program.loginForm.DataContext.BookSak
                        .FirstOrDefault(book => book.Name
                        .Equals(comboBoxBook.SelectedItem.ToString())).BookId;
                    selectedBooking.BookId = BookID;
                }

                // изменяем данные брони
                selectedBooking.DepId = BookDepID;
                selectedBooking.ReaderId = ReaderID;
                selectedBooking.LoanDate = DateTime.ParseExact(textBoxLoanDate.Text, "dd.MM.yyyy", null).Date;

                // сохраняем изменения и обновляем datagridview
                Program.loginForm.DataContext.SaveChanges();
                InitializeData();
                InitializeComboBoxes();
                dataGridViewBookings.Refresh();
                comboBoxBook.SelectedItem = null;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewBookings.SelectedRows)
            {
                int id = (int)selectedRow.Cells[0].Value;
                // ищем элемент для удаления по первичному ключу
                var toDelete = Program.loginForm.DataContext.BookingSak.FirstOrDefault(booking => booking.BookingId.Equals(id));
                var reader = Program.loginForm.DataContext.ReaderSak.Find(toDelete.ReaderId);
                reader.NumberOfBookLoans--;
                if (toDelete != null)
                {
                    Program.loginForm.DataContext.BookingSak.Remove(toDelete);
                    Program.loginForm.DataContext.SaveChanges();
                }
            }

            // обновляем источники данных и обновляем таблицу и combobox
            InitializeComboBoxes();
            InitializeData();
            dataGridViewBookings.Refresh();
        }

        private void dataGridViewBookings_SelectionChanged(object sender, EventArgs e)
        {
            comboBoxDepName.SelectedItem = dataGridViewBookings.CurrentRow.Cells[1].Value;
            comboBoxReader.SelectedItem = dataGridViewBookings.CurrentRow.Cells[2].Value;
            comboBoxBook.SelectedItem = null;
            textBoxLoanDate.Text = ((DateTime)dataGridViewBookings.CurrentRow.Cells[4].Value).ToString("dd.MM.yyyy");
        }

        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            BookingSak newBooking;
            try
            {
                int ReaderID = Program.loginForm.DataContext.ReaderSak
                    .SingleOrDefault(r => (r.LastName + r.FirstName)
                    .Equals(comboBoxReader.SelectedItem.ToString())).ReaderId;
                if (Program.loginForm.DataContext.ReaderSak.Find(ReaderID).NumberOfBookLoans >= 5)
                {
                    MessageBox.Show("Лимит книг выданных читателю не должен превышать *5*");
                }
                int BookDepID = Program.loginForm.DataContext.BookdepartmentSak
                    .SingleOrDefault(dep => dep.DepName.Equals(comboBoxDepName.SelectedItem.ToString())).DepId;
                int BookID = Program.loginForm.DataContext.BookSak
                    .FirstOrDefault(book => book.Name
                    .Equals(comboBoxBook.SelectedItem.ToString())).BookId;

                newBooking = new BookingSak
                {
                    DepId = BookDepID,
                    ReaderId = ReaderID,
                    BookId = BookID,
                    LoanDate = DateTime.ParseExact(textBoxLoanDate.Text, "dd.MM.yyyy", null).Date,
                    ReturnDate = DateTime.ParseExact(textBoxLoanDate.Text, "dd.MM.yyyy", null).Date.AddMonths(1)
                };

                var reader = Program.loginForm.DataContext.ReaderSak.Find(ReaderID);
                reader.NumberOfBookLoans++;

                Program.loginForm.DataContext.Add(newBooking);
                Program.loginForm.DataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

            // обновляем источники данных и обновляем таблицу и combobox
            InitializeData();
            InitializeComboBoxes();
            dataGridViewBookings.Refresh();
        }

        private void comboBoxDepName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // только те книги из конкретного отдела, которые ещё не выданы
            comboBoxBook.DataSource = Program.loginForm.DataContext.BookSak.Where(book => book.BookDepartmentId == Program.loginForm.DataContext.BookdepartmentSak
                 .FirstOrDefault(dep => dep.DepName.Equals(comboBoxDepName.SelectedItem.ToString())).DepId &&
                 !Program.loginForm.DataContext.BookingSak.Select(booking => booking.BookId).Contains(book.BookId))
                .Select(book => book.Name).ToList();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim().ToLower(); // исходная строка без лишних пробелов

            // Проверяем, не является ли значение поисковой строки пустой строкой
            if (string.IsNullOrEmpty(searchValue))
            {
                // Если значение пустое, то сбрасываем видимость всех строк и выходим из метода
                foreach (DataGridViewRow row in dataGridViewBookings.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Отображаем только подходящие по поиску строки
            foreach (DataGridViewRow row in dataGridViewBookings.Rows)
            {
                dataGridViewBookings.CurrentCell = null;

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
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }
    }
}
