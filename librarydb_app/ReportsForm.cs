using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace librarydb_app
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            InitializeComboboxes();
        }

        private void InitializeComboboxes()
        {
            comboBoxReaders.DataSource = Program.loginForm.DataContext.ReaderSak
                .Select(reader => reader.LastName.ToString() + reader.FirstName + reader.MiddleName).ToList();
            comboBoxReports.Items.Add("Книги, выданные читателю");
            comboBoxReports.Items.Add("Книги с просроченным сроком сдачи у читателя");
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            // имя файла и путь
            string fileName = Path
                .Combine("..\\..\\DbReports", $"Bookings_{DateTime.Now.ToString("ddMMyyyy_HHmmss")}.xml");

            // сохранение данных в xml 
            using (var writer = XmlWriter.Create(fileName))
            {
                // если список всех выданных читателю книг
                if (comboBoxReports.SelectedIndex == 0)
                {
                    var reader = Program.loginForm.DataContext.ReaderSak
                        .FirstOrDefault(r => (r.LastName + "" + r.FirstName + r.MiddleName) == comboBoxReaders.SelectedItem.ToString());

                    if (reader != null)
                    {
                        var bookings = Program.loginForm.DataContext.BookingSak.Where(b => b.ReaderId == reader.ReaderId).ToList();

                        // Начало документа
                        writer.WriteStartDocument();

                        // Начало корневого элемента
                        writer.WriteStartElement("booksLoanedToReader");

                        // Запись данных о читателе
                        writer.WriteStartElement("reader");
                        writer.WriteElementString("LastName", reader.LastName.ToString());
                        writer.WriteElementString("FirstName", reader.FirstName.ToString());
                        writer.WriteElementString("MiddleName", reader.MiddleName.ToString());
                        writer.WriteElementString("Address", reader.HomeAddress.ToString());
                        writer.WriteElementString("PhoneNumber", reader.PhoneNumber.ToString());

                        writer.WriteStartElement("books");
                        foreach (var booking in bookings)   // для каждой выдачи книги конкретному читателю
                        {
                            // находим книгу по её ID
                            var book = Program.loginForm.DataContext.BookSak.FirstOrDefault(b => b.BookId == booking.BookId);

                            if (book != null)
                            {
                                // Запись данных о книгах
                                writer.WriteStartElement("book");
                                writer.WriteElementString("Name", book.Name);
                                writer.WriteElementString("LoanDate", booking.LoanDate.ToString());
                                writer.WriteElementString("ReturnDate", booking.ReturnDate.ToString());
                                writer.WriteEndElement();
                            }
                        }
                        // конец элемента books
                        writer.WriteEndElement();
                    }
                    // конец элемента reader
                    writer.WriteEndElement();

                    // Конец корневого элемента
                    writer.WriteEndElement();

                    // Конец документа
                    writer.WriteEndDocument();

                    MessageBox.Show("Отчет сохранен в папке DbReports");
                }
            }
        }
    }
}
