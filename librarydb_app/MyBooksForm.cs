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
                                { // создаем анонимный объект, содержащий нужные поля для дальнейшей группировки
                                    BookId = book.BookId,
                                    BookTitle = book.Name,
                                    LoanDate = booking.LoanDate,
                                    ReturnDate = booking.ReturnDate
                                } into books
                                group books by new
                                { // группируем записи по нескольким полям
                                    books.BookId,
                                    books.BookTitle,
                                    books.LoanDate,
                                    books.ReturnDate
                                } into bookAuthors
                                select new
                                { // создаем новый объект для результата запроса
                                    BookId = bookAuthors.Key.BookId, // поле BookId вытаскиваем из ключа группировки
                                    BookTitle = bookAuthors.Key.BookTitle, // аналогично для BookTitle
                                    Authors = string.Join(", ", (from author in Program.loginForm.DataContext.AuthorSak
                                                                 join bookAuthor in Program.loginForm.DataContext.BookhasauthorSak on author.AuthorId equals bookAuthor.AuthorId
                                                                 where bookAuthor.BookId == bookAuthors.Key.BookId
                                                                 select $"{author.LastName} {author.FirstName} {author.MiddleName}").ToList()), // объединяем всех авторов в одну строку с помощью метода Join
                                    LoanDate = bookAuthors.Key.LoanDate, // аналогично для LoanDate
                                    ReturnDate = bookAuthors.Key.ReturnDate // аналогично для ReturnDate
                                };

                    dataGridViewMyBooks.DataSource = query.ToList(); // устанавливаем результат запроса в качестве источника данных для dataGridViewMyBooks

                }
            }
        }
    }
}
