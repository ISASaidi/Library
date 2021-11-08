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
    public partial class AddMember : Form
    {
  
        public AddMember()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            btnAdd.Enabled = false;// Waar moet ik het plaatsen
            Thread.Sleep(1000);
            btnAdd.Enabled = true;

            using SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");

            using var command = connection.CreateCommand();

            command.CommandText = "insert into [TableMember] (FirstName, LastName, Address, HouseNumber, ZipCode, City, Phone_number, Mail ) Values (@FirstName, @LastName, @Address, @HouseNumber, @ZipCode, @City, @Phone_number, @Mail); select scope_identity()";
            command.Parameters.AddWithValue("@FirstName", txtFirstname.Text );
            command.Parameters.AddWithValue("@LastName", txtLastname.Text);
            command.Parameters.AddWithValue("@Address", txtAddress.Text);
            command.Parameters.AddWithValue("@HouseNumber", txtHouseNumber.Text);
            command.Parameters.AddWithValue("@ZipCode", txtZipcode.Text);
            command.Parameters.AddWithValue("@City",txtCity.Text);
            command.Parameters.AddWithValue("@Phone_number", txtPhone_number.Text);
            command.Parameters.AddWithValue("@Mail", txtMail.Text);
            
            using var reader = command.ExecuteReader();// la connection avec le server ne se fait pas.
            reader.Read();
            
            MessageBox.Show("The Member has been added");

        }
    }
}
