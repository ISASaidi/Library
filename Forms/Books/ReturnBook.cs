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

            try
            {

                int isbn = int.Parse(txtIsbn.Text);

                borrowRepository.DeleteBorrowedBook(isbn);
                borrowRepository.UpdateAvailableBook(isbn);
              
                MessageBox.Show($"The book with ISBN {isbn} has been returned and updated");
            }
            finally
            {
                btnReturn.Enabled = true;
            }

        }
    }
}
