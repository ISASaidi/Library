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
    public partial class ViewBooks : Form
    {

        string conn = "Data Source = (local); Initial Catalog = Library; Integrated Security = True";
        public ViewBooks()
        {
            InitializeComponent();
        }

       
        private void ViewBooks_Load(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(conn);

            var command = connection.CreateCommand();
            command.CommandText = "select * from [TableBook]";

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewBook.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(conn);

            var command = connection.CreateCommand();
            command.CommandText = "select from [TableBook] where Isbn='" + txtSearchIsbn.Text + "'";
            using var reader = command.ExecuteReader();
            reader.Read();
        }
    }
}
