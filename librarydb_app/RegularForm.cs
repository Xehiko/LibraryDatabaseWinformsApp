using System.Windows.Forms;

namespace librarydb_app
{
    public partial class RegularForm : Form
    {
        public RegularForm()
        {
            InitializeComponent();
        }

        private void buttonSignOut_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Program.loginForm.Show();
        }

        private void buttonMyBooks_Click(object sender, System.EventArgs e)
        {
            MyBooksForm myBooksForm = new MyBooksForm();
            myBooksForm.ShowDialog();
        }

        private void buttonLoanBook_Click(object sender, System.EventArgs e)
        {
            LoanBookForm loanBookForm = new LoanBookForm();
            loanBookForm.ShowDialog();
        }

        private void RegularForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
