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
        MemberRepository memberRepository = new MemberRepository();

        public UpdateMember()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            try
            {
                Member member = new Member(txtFirstName.Text, txtLastName.Text, txtAddress.Text, int.Parse(txtHouseNumber.Text), int.Parse(txtZipCode.Text), txtCity.Text, int.Parse(txtPhoneNumber.Text), txtMail.Text);
                var member_id = int.Parse(txtMember_Id.Text);
                memberRepository.UpdateMember(member, member_id);

                MessageBox.Show($"The member with ID {member_id} has been updated");
              
            }
            finally
            {
                btnUpdate.Enabled = true;
            }

        }
    }
}
