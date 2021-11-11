using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class ReturnBook : Form
    {

        BorrowRepository borrowRepository = new BorrowRepository();
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnReturn.Enabled = false;
            bool loop = true;

            do
            {

                if (string.IsNullOrEmpty(txtIsbn.Text))
                {

                    string message = "Fill the ISBN in ";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Close();

                    ReturnBook book = new ReturnBook();
                    book.Show(); break;
                }
                else
                {
                    loop = false;

                    try
                    {

                        int isbn = int.Parse(txtIsbn.Text);

                        borrowRepository.DeleteBorrowedBook(isbn);
                        borrowRepository.UpdateAvailableBook(isbn);

                        MessageBox.Show($"The book with ISBN {isbn} has been returned and updated");
                        this.Close();
                    }
                    finally
                    {
                        btnReturn.Enabled = true;
                    }

                }
            
            } while (loop);

        }
}
}
