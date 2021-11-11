using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace Library
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;



            try
            {
                using SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = " select 1 from LoginTable where username =@Username and password=@Password";
                command.Parameters.AddWithValue("@Username", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);
                using var reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.Show();

                }
                else
                {
                    MessageBox.Show("You have put a wrong username of password. Please retry", "Error", MessageBoxButtons.OK);
                }

            }
            finally
            {
                btnLogin.Enabled = true;
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)// ik krijg het niet weg
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
