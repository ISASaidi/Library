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
    public partial class ViewMember : Form
    {


        MemberRepository memberRepository = new MemberRepository();

        public ViewMember()
        {
            InitializeComponent();
        }


        private void SetDataGridView(SqlCommand command)
        {

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewMember.DataSource = dt;
        }


        private void ViewMember_Load(object sender, EventArgs e)
        {

            SetDataGridView(memberRepository.GetCommandForAllMembers());

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;

            bool loop = true;

            do
            {

                if (string.IsNullOrEmpty(txtSearchMember_Id.Text))
                {
                    string message = "Fill the Member ID in ";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Close();

                    ViewMember member = new ViewMember();
                    member.Show(); break;
                }
                else
                {
                    loop = false;

                    try
                    {
                        SetDataGridView(memberRepository.GetCommandFindMember(int.Parse(txtSearchMember_Id.Text)));

                    }
                    finally
                    {

                        btnSearch.Enabled = true;
                    }
                }
            } while (loop);

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            btnGetAll.Enabled = false;
            try
            {
                SetDataGridView(memberRepository.GetCommandForAllMembers());

            }
            finally
            {

                btnGetAll.Enabled = true;
            }
        }
    }
}
