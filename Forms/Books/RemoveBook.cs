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
using System.Threading;

namespace Library
{
    public partial class RemoveBook : Form
    {
        BookRepository br = new BookRepository();
        public RemoveBook()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)//Verwijdert het boek in [TableBook]
        {
            btnRemove.Enabled = false;
            bool loop = true;


            do
            {
                if (string.IsNullOrEmpty(txtIsbn.Text))
                {

                    string message = "Fill the ISBN in ";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Close();

                    RemoveBook book = new RemoveBook();
                    book.Show(); break;
                }

                else
                {

                    loop = false;

                    try
                    {

                        br.RemoveBook(int.Parse(txtIsbn.Text));
                        MessageBox.Show("The book has been removed");
                        this.Close();
                    }
                    finally
                    {
                        btnRemove.Enabled = true;

                    }

                }

            } while (loop);

        }
    }
}
