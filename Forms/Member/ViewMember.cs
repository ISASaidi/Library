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
    public partial class ViewMember : Form
    {

        string conn = "Data Source = (local); Initial Catalog = Library; Integrated Security = True";

        public ViewMember()
        {
            InitializeComponent();
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(conn);

            using var command = connection.CreateCommand();
            command.CommandText = "select * from [TableMember]";

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewMember.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;// Waar moet ik het plaatsen
            try
            {
                Member mbr = new Member(int.Parse(txtSearchMember_Id.Text));
                mbr.SearchMember();
            }
            finally
            {

                btnSearch.Enabled = true;
            }

        }
    }
}
