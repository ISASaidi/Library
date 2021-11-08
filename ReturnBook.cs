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
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");

            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM [TableBorrows] where Isbn= '" + txtIsbn + "'";

            command.CommandText = "UPDATE [TableBook] SET [Status]=@Status WHERE Isbn = '" + txtIsbn + "'";
            command.Parameters.AddWithValue("@Status", "Free");
            using var reader = command.ExecuteReader();
            reader.Read();
        }
    }
}
