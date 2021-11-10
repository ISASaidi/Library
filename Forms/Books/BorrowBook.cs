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


        public BorrowBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            btnSave.Enabled = false;
            try
            {

                Borrow brw = new Borrow(int.Parse(txtIsbn.Text), int.Parse(txtMemberId.Text), dateTimePickerPurchaseDate.Value, dateTimePickerReturnDate.Value);
                brw.BorrowBook();
            }
            catch
            {

                btnSave.Enabled = true;
            }

        }

        private void Borrowing_Returning_Load(object sender, EventArgs e)
        {

            using SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");
            connection.Open();
            using var command = connection.CreateCommand();

            command.CommandText = " select * from [TableBorrows]";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBorrows.DataSource = dt;

        }
    }
}
