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
    public partial class UpdateMember : Form
    {
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;// Waar moet ik het plaatsen
            Thread.Sleep(1000);
            btnUpdate.Enabled = true;

            using SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");

            var command = connection.CreateCommand();
            command.CommandText = "UPDATE [TableMember] SET [FirstName]=@FirstName, [LastName]=@LastName, [Address]=@Address, [HouseNumber]=@HouseNumber, [ZipCode]=@ZipCode, [City]=@City, [Phone_number]=@Phone_number, [Mail]=@Mail) WHERE Member_id='"+txtMember_Id.Text+"'";

            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            command.Parameters.AddWithValue("@LastName",txtLastName.Text);
            command.Parameters.AddWithValue("@Address",txtAddress.Text);
            command.Parameters.AddWithValue("@HouseNumber",txtHouseNumber.Text);
            command.Parameters.AddWithValue("@ZipCode",txtZipCode.Text);
            command.Parameters.AddWithValue("@City",txtCity.Text);
            command.Parameters.AddWithValue("@Phone_number",txtPhoneNumber.Text);
            command.Parameters.AddWithValue("@Mail",txtMail.Text);
           
            command.ExecuteNonQuery();
        }
    }
}
