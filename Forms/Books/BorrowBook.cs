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
    public partial class BorrowBook : Form
    {

        BorrowRepository borrowRepository = new BorrowRepository();

        public BorrowBook()
        {
            InitializeComponent();
        }

        private void setDataGridView(SqlCommand command)
        {

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewBorrows.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            btnSave.Enabled = false;
            try
            {

                int isbn = int.Parse(txtIsbn.Text);

                Borrow book = new Borrow(isbn, int.Parse(txtMemberId.Text), dateTimePickerPurchaseDate.Value, dateTimePickerReturnDate.Value);
                borrowRepository.AddBorrowedBook(book);

                SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");
                using var command = connection.CreateCommand();
                command.CommandText = " Select * from [TableBorrows]";

                setDataGridView(command);

                borrowRepository.UpdateBorrowedBook(isbn);
               
                MessageBox.Show("The book has been borrowed and updated");


            }
            finally
            {

                btnSave.Enabled = true;
            }

        }

      

        private void Borrowing_Returning_Load(object sender, EventArgs e)
        {
            

            setDataGridView(borrowRepository.GetAllBorrowedBook());

        }
    }
}
