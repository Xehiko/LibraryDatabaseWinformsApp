using librarydb_app.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class LoanBookForm : Form
    {
        public LoanBookForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            var query = from book in Program.loginForm.DataContext.BookSak
                where !Program.loginForm.DataContext.BookingSak.Any(b => b.BookId == book.BookId)
                select new
                {
                    BookTitle = book.Name,
                    Authors = string.Join(", ", (from author in Program.loginForm.DataContext.AuthorSak
                                          join bookAuthor in Program.loginForm.DataContext.BookhasauthorSak on author.AuthorId equals bookAuthor.AuthorId
                                          where bookAuthor.BookId == book.BookId
                                          select $"{author.LastName} {author.FirstName} {author.MiddleName}").ToList())
                };
            dataGridViewBooks.DataSource = query.ToList();
        }

        private void buttonLoanBook_Click(object sender, EventArgs e)
        {
            BookingSak newBooking;
            try
            {
                int ReaderID = Program.loginForm.DataContext.UserSak
                    .Where(u => u.Login == Program.loginForm.Login)
                    .Join(Program.loginForm.DataContext.ReaderSak, u => u.Id, r => r.UserId, (u, r) => r.ReaderId)
                    .FirstOrDefault();
                if (Program.loginForm.DataContext.ReaderSak.Find(ReaderID).NumberOfBookLoans >= 5)
                {
                    MessageBox.Show("Лимит книг выданных читателю не должен превышать *5*");
                }
                int BookID = Program.loginForm.DataContext.BookSak
                    .FirstOrDefault(book => book.Name
                    .Equals(textBoxBookName.Text)).BookId;
                int BookDepID = Program.loginForm.DataContext.BookSak.Find(BookID).BookDepartmentId;

                newBooking = new BookingSak
                {
                    DepId = BookDepID,
                    ReaderId = ReaderID,
                    BookId = BookID,
                    LoanDate = DateTime.Now.Date,
                    ReturnDate = DateTime.Now.Date.AddMonths(1)
                };
                Program.loginForm.DataContext.Add(newBooking);
                Program.loginForm.DataContext.SaveChanges();

                var reader = Program.loginForm.DataContext.ReaderSak.Find(ReaderID);
                reader.NumberOfBookLoans++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

            // обновляем источники данных и обновляем таблицу и combobox
            InitializeData();
            dataGridViewBooks.Refresh();

            MessageBox.Show("Книга успешно взята, срок 30 дней");
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            textBoxBookName.Text = dataGridViewBooks.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
