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

        string conn = "Data Source=(local);Initial Catalog=Library;Integrated Security=True";

        public BorrowBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            btnSave.Enabled = false;// Waar moet ik het plaatsen
            Thread.Sleep(1000);
            btnSave.Enabled = true;
            using SqlConnection connection = new SqlConnection(conn);

            using var command = connection.CreateCommand();

            // ik moet nagaan of het boek al geboekt is, anders een MessageBox

            /*
             * 
             * Book bk= new Book();
             * 
             * if (bk.StatusBook = "Borrowed")
             * {
             * 
             * Messagebox.Show("Book is already borrowed
             * 
             * } else {
             * 
             * command.CommandText = "insert into [TableBorrows] (Isbn, Member_Id, Status, Purchase_Date, Return_Date) Values (@Isbn, @Member_Id, @Status, @Purchase_order, @Return_Date); select scope_identity()";
                command.Parameters.AddWithValue("@Isbn", txtIsbn.Text);
                command.Parameters.AddWithValue("@Member_Id", txtMemberId.Text);
                command.Parameters.AddWithValue("@Purchase_Date", dateTimePickerPurchaseDate.Text);
                command.Parameters.AddWithValue("@Return_Date", dateTimePickerReturnDate.Text);


                command.CommandText = "UPDATE  [TableBook] SET [Status]=@Status where [Isbn]= '"+txtIsbn.Text+"'";// je peux sélectionner le scope_identity?
                command.Parameters.AddWithValue("@Status", "Borrowed");

            
            using var reader = command.ExecuteReader();
            reader.Read();
             * 
             * }
             * 
             */


            command.CommandText = "insert into [TableBorrows] (Isbn, Member_Id, Status, Purchase_Date, Return_Date) Values (@Isbn, @Member_Id, @Status, @Purchase_order, @Return_Date); select scope_identity()";
                command.Parameters.AddWithValue("@Isbn", txtIsbn.Text);
                command.Parameters.AddWithValue("@Member_Id", txtMemberId.Text);
                command.Parameters.AddWithValue("@Purchase_Date", dateTimePickerPurchaseDate.Text);
                command.Parameters.AddWithValue("@Return_Date", dateTimePickerReturnDate.Text);


                command.CommandText = "UPDATE  [TableBook] SET [Status]=@Status where [Isbn]= '"+txtIsbn.Text+"'";// je peux sélectionner le scope_identity?
                command.Parameters.AddWithValue("@Status", "Borrowed");

            
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
