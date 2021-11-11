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
    public partial class AddBook : Form
    {

        BookRepository bookRepository = new BookRepository();

        public AddBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;

            
            bool loop = true;

            do
            {

                if ((string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtEdition.Text) || string.IsNullOrEmpty(txtAuthor.Text) || string.IsNullOrEmpty(txtGenre.Text)))
                {

                    string message = "Fill in all the boxes";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Close();

                    AddBook book = new AddBook();
                    book.Show(); break;
                }
                else
                {
                    loop = false;

                    try
                    {
                        Book bk = new Book(txtTitle.Text, txtEdition.Text, txtAuthor.Text, txtGenre.Text);

                        bookRepository.AddBook(bk);
                        MessageBox.Show("The book has been added");
                        this.Close();
                    }

                    finally
                    {
                        btnAdd.Enabled = true;
                    }
                }



            } while (loop);


        }

    }
}


