using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)// moet weg
        {
           

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            addBookToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            addBookToolStripMenuItem.Enabled = true;

            AddBook ab = new AddBook();
            ab.Show();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            updateBookToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            updateBookToolStripMenuItem.Enabled = true;

            UpdateBook ub = new UpdateBook();
            ub.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            viewBooksToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            viewBooksToolStripMenuItem.Enabled = true;

            ViewBooks vb = new ViewBooks();
            vb.Show();
        }

        private void borrowingToolStripMenuItem_Click(object sender, EventArgs e)// ik krijg het niet weg
        {
           
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMemberToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            addMemberToolStripMenuItem.Enabled = true;

            AddMember arm = new AddMember();
            arm.Show();

        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            viewMembersToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            viewMembersToolStripMenuItem.Enabled = true;

            ViewMember vm = new ViewMember();
            vm.Show();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

            updateMemberToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            updateMemberToolStripMenuItem.Enabled = true;

            UpdateMember um = new UpdateMember();
            um.Show();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeBookToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            removeBookToolStripMenuItem.Enabled = true;

            RemoveBook rb = new RemoveBook();
            rb.Show();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrowBookToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            borrowBookToolStripMenuItem.Enabled = true;

            BorrowBook br = new BorrowBook();
            br.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnBookToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            returnBookToolStripMenuItem.Enabled = true;

            ReturnBook bk = new ReturnBook();
            bk.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            exitToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            exitToolStripMenuItem.Enabled = true;

            Application.Exit();
        }
    }
}
