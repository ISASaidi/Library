using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();
            ab.Show();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBook ub = new UpdateBook();
            ub.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks vb = new ViewBooks();
            vb.Show();
        }

        private void borrowingToolStripMenuItem_Click(object sender, EventArgs e)// ik krijg het niet weg
        {
           
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember arm = new AddMember();
            arm.Show();

        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMember vm = new ViewMember();
            vm.Show();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMember um = new UpdateMember();
            um.Show();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveBook rb = new RemoveBook();
            rb.Show();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBook br = new BorrowBook();
            br.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook bk = new ReturnBook();
            bk.Show();
        }
    }
}
