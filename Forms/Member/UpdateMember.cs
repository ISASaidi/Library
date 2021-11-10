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
            btnUpdate.Enabled = false;
            try
            {
                Member mbr = new Member(txtFirstName.Text, txtLastName.Text, txtAddress.Text, int.Parse(txtHouseNumber.Text), int.Parse(txtZipCode.Text), txtCity.Text, int.Parse(txtPhoneNumber.Text), txtMail.Text);
                mbr.Member_id = int.Parse(txtMember_Id.Text);
                mbr.UpdateMember();
            }
            finally
            {
                btnUpdate.Enabled = true;
            }

        }
    }
}
