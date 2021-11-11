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
            bool loop = true;

            do
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtHouseNumber.Text)
                    || string.IsNullOrEmpty(txtZipCode.Text) || string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtMail.Text))
                {

                    string message = "Fill in all the boxes";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Close();

                    AddMember member = new AddMember();
                    member.Show(); break;
                }
                else
                {

                    try
                    {

                        if (Int32.TryParse(txtZipCode.Text, out int zipCode) || Int32.TryParse(txtPhoneNumber.Text, out int phoneNumber) || Int32.TryParse(txtMember_Id.Text, out int member_Id))
                        {
                            loop = false;
                            Member member = new Member(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtHouseNumber.Text, int.Parse(txtZipCode.Text), txtCity.Text, int.Parse(txtPhoneNumber.Text), txtMail.Text);
                            int member_id = int.Parse(txtMember_Id.Text);
                            memberRepository.UpdateMember(member, member_id);

                            MessageBox.Show($"The member with ID {member_id} has been updated");
                            this.Close();
                        }
                        else
                        {
                            string message = "Fill only numbers for the Member ID, the ZipCode and the Phonenumber";
                            string title = "Error";
                            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            this.Close();

                            UpdateMember newmember = new UpdateMember();
                            newmember.Show(); break;
                        }

                    }
                    finally
                    {
                        btnUpdate.Enabled = true;
                    }
                }
            } while (loop);

        }
    }
}
