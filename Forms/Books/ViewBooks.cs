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
    public partial class ViewBooks : Form
    {
        BookRepository bookRepository = new BookRepository();

        public ViewBooks()
        {
            InitializeComponent();
        }



        private void setDataGridView(SqlCommand command)
        {

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewBook.DataSource = dt;
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {

            setDataGridView(bookRepository.GetCommandForAllBooks());
        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            bool loop = true;

            do
            {
                if (string.IsNullOrEmpty(txtSearchIsbn.Text))
                {

                    string message = "Fill the ISBN in ";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Close();

                    ViewBooks book = new ViewBooks();
                    book.Show(); break;
                }
                else
                {
                    loop = false;

                    try
                    {


                        setDataGridView(bookRepository.GetCommandForBook(int.Parse(txtSearchIsbn.Text)));

                    }

                    finally
                    {

                        btnSearch.Enabled = true;
                    }

                }
            } while (loop);
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {


            setDataGridView(bookRepository.GetCommandForAllBooks());

        }
    }
}
