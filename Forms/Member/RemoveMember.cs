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
    public partial class RemoveMember : Form
    {
        public RemoveMember()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            using SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");
            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM [TableMember] where Member_Id= '" + txtMemberId.Text + "'";
            using var reader = command.ExecuteReader(); // la connection avec le server ne se fait pas.
            reader.Read();
            MessageBox.Show("The member has been removed");
        }
    }
}
