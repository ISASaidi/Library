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
            try
            {

                Book bk = new Book(txtTitle.Text, txtEdition.Text, txtAuthor.Text, txtGenre.Text);
                
                br.UpdateBook(bk, comboBoxStatus.Text, int.Parse(txtIsbn.Text));
            }
            finally
            {

                btnSave.Enabled = true;
            }


        }

    }
}

