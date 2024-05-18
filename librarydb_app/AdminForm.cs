using System.Windows.Forms;

namespace librarydb_app
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSignOut_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Program.loginForm.Show();
        }

        private void buttonAuthors_Click(object sender, System.EventArgs e)
        {
            AuthorsForm authorsForm = new AuthorsForm();
            authorsForm.ShowDialog();
        }

        private void buttonHouse_Click(object sender, System.EventArgs e)
        {
            PublishingHouseForm publishingHouseForm = new PublishingHouseForm();
            publishingHouseForm.ShowDialog();
        }

        private void buttonUsers_Click(object sender, System.EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
        }

        private void buttonReaders_Click(object sender, System.EventArgs e)
        {
            ReadersForm readersForm = new ReadersForm();
            readersForm.ShowDialog();
        }

        private void buttonDeps_Click(object sender, System.EventArgs e)
        {
            DepsForm depsForm = new DepsForm();
            depsForm.ShowDialog();
        }

        private void buttonBooks_Click(object sender, System.EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.ShowDialog();
        }

        private void buttonBookings_Click(object sender, System.EventArgs e)
        {
            BookingsForm bookingsForm = new BookingsForm();
            bookingsForm.ShowDialog();
        }

        private void buttonBookHasAuthor_Click(object sender, System.EventArgs e)
        {
            BooksAuthorsForm booksAuthorsForm = new BooksAuthorsForm();
            booksAuthorsForm.ShowDialog();
        }

        private void buttonAuthorPublishing_Click(object sender, System.EventArgs e)
        {
            AuthorsPublishingForm authorsPublishingForm = new AuthorsPublishingForm();
            authorsPublishingForm.ShowDialog();
        }
    }
}