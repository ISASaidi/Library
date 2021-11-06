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
    public partial class Borrowing_Returning : Form
    {

        string conn = "@Data Source=(local);Initial Catalog=Library;Integrated Security=True";

        public Borrowing_Returning()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(conn);

            using var command = connection.CreateCommand();

            // De statuut hangt af van wat er gevinkt wordt. Ik moet dus met een if werken die nagaat of de checkbox gecheckt is of niet

            if (checkBoxReturn.Checked == true)
            {

                command.CommandText = "insert into [TableBorrows] (Isbn, Member_Id, Status, Purchase_Date, Return_Date) Values (@Isbn, @Member_Id, @Status, @Purchase_order, @Return_Date); select scope_identity()";
                command.Parameters.AddWithValue("@Isbn", txtIsbn.Text);
                command.Parameters.AddWithValue("@Member_Id", txtMemberId.Text);
                command.Parameters.AddWithValue("@Status", checkBoxReturn.Text);
                command.Parameters.AddWithValue("@Purchase_Date", dateTimePickerPurchaseDate.Text);
                command.Parameters.AddWithValue("@Return_Date", dateTimePickerReturnDate.Text);
            }
            else
            {
                command.CommandText = "DELETE FROM [TableBorrows] where Isbn= '" + txtIsbn + "', Member_ID= '" +txtMemberId + "'";
            }
            
            using var reader = command.ExecuteReader();
            reader.Read();


        }

        private void Borrowing_Returning_Load(object sender, EventArgs e)
        {

            using SqlConnection connection = new SqlConnection(conn);

            using var command = connection.CreateCommand();

            command.CommandText = " select * from [TableBorrows]";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBorrows.DataSource = dt;

        }
    }
}
