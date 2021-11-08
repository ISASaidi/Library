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
            btnLogin.Enabled = false;// Waar moet ik het plaatsen
            Thread.Sleep(1000);
            btnLogin.Enabled = true;

            using SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");
            var command = connection.CreateCommand();
            command.CommandText = " select * from LoginTable where username ='"+txtUsername.Text+"'and password='"+txtPassword+"'";

            SqlDataAdapter da = new SqlDataAdapter(command); 
            DataSet ds = new DataSet();
            da.Fill(ds);

            //Door de Dataset door te geven via een DataAdapter, vul ik de records van mijn tafel met de waarde van mijn SelectCommand.

            if (ds.Tables[0].Rows.Count != 0)// De voorwaarde heb ik letterlijk van internet overgenomen, maar werkt niet. Ik zie niet welke voorwaarde ik moet zetten.
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();

            }
            else
            {
                MessageBox.Show("You have put a wrong username of password. Please retry", "Error",MessageBoxButtons.OK);
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
