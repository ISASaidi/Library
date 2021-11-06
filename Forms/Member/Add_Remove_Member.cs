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
    public partial class Add_Remove_Member : Form
    {
        string conn = "@Data Source=(local);Initial Catalog=Library;Integrated Security=True";

        public Add_Remove_Member()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using SqlConnection connection = new SqlConnection(conn);

            using var command = connection.CreateCommand();

            command.CommandText = "insert into [TableBook] (FirstName, LastName, Address, HouseNumber, ZipCode, City, Phone_number, Mail ) Values (@FirstName, @LastName, @Address, @HouseNumber, @ZipCode, @City, @Phone_number, @Mail); select scope_identity()";
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

        private void btnRemove_Click(object sender, EventArgs e)
        {


            using SqlConnection connection = new SqlConnection(conn);

            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM [TableBook] where Title= '" + txtFirstname+ "', LastName = '" + txtLastname.Text+ "'," +
                " Address='"+txtAddress.Text+ "', HouseNumber='" + txtHouseNumber + "', ZipCode='" + txtZipcode + "'," +
                " City='" + txtCity.Text + "', Phone_number='" + txtPhone_number.Text + "', Mail='" + txtMail.Text + "'";// Je devrais le faire avec le Id
            using var reader = command.ExecuteReader(); // la connection avec le server ne se fait pas.
            reader.Read();
            MessageBox.Show("The member has been removed");
        }
    }
}
