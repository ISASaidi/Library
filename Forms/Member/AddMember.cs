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
            try
            {
                Member mbr = new Member(txtFirstname.Text, txtLastname.Text, txtAddress.Text, int.Parse(txtHouseNumber.Text), int.Parse(txtZipcode.Text), txtCity.Text, int.Parse(txtPhone_number.Text), txtMail.Text);
                mbr.AddMember();
            }
            finally
            {

                btnAdd.Enabled = true;
            }

        }
    }
}
