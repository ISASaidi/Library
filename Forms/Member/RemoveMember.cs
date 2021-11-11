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
    public partial class RemoveMember : Form
    {
        MemberRepository memberRepository = new MemberRepository();
        public RemoveMember()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            try
            {
               
                int member_id = int.Parse(txtMemberId.Text);
                memberRepository.RemoveMember(member_id);

                MessageBox.Show($"The member with the ID {member_id} has been removed");
            }
            finally
            {
                btnRemove.Enabled = true;
            }

        }
    }
}
