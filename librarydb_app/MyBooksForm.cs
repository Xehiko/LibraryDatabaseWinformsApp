using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace librarydb_app
{
    public partial class MyBooksForm : Form
    {
        public MyBooksForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            int readerId;

            var curUser = Program.loginForm.DataContext.UserSak.FirstOrDefault(user => user.Login == Program.loginForm.Login);

            if (curUser != null)
            {
                var curReader = Program.loginForm.DataContext.ReaderSak.FirstOrDefault(r => r.UserId == curUser.Id);

                if (curReader != null)
                {
                    readerId = curReader.ReaderId;

                    var query = from booking in Program.loginForm.DataContext.BookingSak // выбираем записи из таблицы BookingSak
                                where booking.ReaderId == readerId // фильтруем по Id читателя
                                join book in Program.loginForm.DataContext.BookSak on booking.BookId equals book.BookId // объединяем с таблицей BookSak по полю BookId
                                select new
                                { // создаем новый объект для результата запроса
                                    BookId = booking.Book.BookId,
                                    BookTitle = booking.Book.Name,
                                    Authors = string.Join(", ", (from author in Program.loginForm.DataContext.AuthorSak
                                                                 join bookAuthor in Program.loginForm.DataContext.BookhasauthorSak on author.AuthorId equals bookAuthor.AuthorId
                                                                 where bookAuthor.BookId == booking.BookId
                                                                 select $"{author.LastName} {author.FirstName} {author.MiddleName}").ToList()), // объединяем всех авторов в одну строку с помощью метода Join
                                    LoanDate = booking.LoanDate,
                                    ReturnDate = booking.ReturnDate
                                };

                    dataGridViewMyBooks.DataSource = query.ToList(); // устанавливаем результат запроса в качестве источника данных для dataGridViewMyBooks

                }
            }
        }
    }
}
