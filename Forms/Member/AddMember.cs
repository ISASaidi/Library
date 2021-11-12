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

        MemberRepository memberRepository = new MemberRepository();

        public AddMember()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)// Voegt member in [TableMember]
        {

            btnAdd.Enabled = false;

            bool loop = true;

            do
            {
                if (string.IsNullOrEmpty(txtFirstname.Text) || string.IsNullOrEmpty(txtLastname.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtHouseNumber.Text)
                    || string.IsNullOrEmpty(txtZipcode.Text) || string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtPhone_number.Text) || string.IsNullOrEmpty(txtMail.Text))
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


                        if (Int32.TryParse(txtZipcode.Text, out int zipCode) || Int32.TryParse(txtPhone_number.Text, out int phoneNumber))
                        {
                            loop = false;
                            Member member = new Member(txtFirstname.Text, txtLastname.Text, txtAddress.Text, txtHouseNumber.Text, int.Parse(txtZipcode.Text), txtCity.Text, int.Parse(txtPhone_number.Text), txtMail.Text);
                            memberRepository.AddMember(member);

                            MessageBox.Show("The Member has been added");
                            this.Close();
                        }
                        else
                        {
                            string message = "Fill only numbers for the ZipCode and the Phonenumber";
                            string title = "Error";
                            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            this.Close();

                            AddMember newmember = new AddMember();
                            newmember.Show(); break;
                        }

                    }
                    finally
                    {

                        btnAdd.Enabled = true;
                    }

                }

            } while (loop);
        }
    }
}
