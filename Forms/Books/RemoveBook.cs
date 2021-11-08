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
    public partial class RemoveBook : Form
    {
        public RemoveBook()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");

            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM [TableBook] where Isbn= '" + txtIsbn.Text + "'";
            using var reader = command.ExecuteReader(); // la connection avec le server ne se fait pas.
            reader.Read();
            MessageBox.Show("The book has been removed");
        }
    }
}
