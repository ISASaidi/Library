using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Library
{
    public partial class UpdateBook : Form
    {

        BookRepository br = new BookRepository();
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            bool loop = true;

            do
            {


                if((string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtEdition.Text) || string.IsNullOrEmpty(txtAuthor.Text) || string.IsNullOrEmpty(txtGenre.Text)))
                {

                    string message = "Fill in all the boxes";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Close();

                    UpdateBook book = new UpdateBook();
                    book.Show(); break;

                }
                else
                {
                    loop = false;
                    try
                    {

                        Book bk = new Book(txtTitle.Text, txtEdition.Text, txtAuthor.Text, txtGenre.Text);

                        br.UpdateBook(bk, comboBoxStatus.Text, int.Parse(txtIsbn.Text));
                        MessageBox.Show("Book has been updated");
                        this.Close();
                        
                    }
                    finally
                    {

                        btnSave.Enabled = true;
                    }

                }

            } while (loop);

        }

    }
}

