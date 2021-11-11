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


        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            addBookToolStripMenuItem.Enabled = false;

            try
            {

                AddBook ab = new AddBook();
                ab.Show();
            }
            finally
            {
                addBookToolStripMenuItem.Enabled = true;
            }
           
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            updateBookToolStripMenuItem.Enabled = false;

            try
            {

                UpdateBook ub = new UpdateBook();
                ub.Show();
            }
            finally
            {
                updateBookToolStripMenuItem.Enabled = true;
            }
            
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            viewBooksToolStripMenuItem.Enabled = false;

            try
            {

                ViewBooks vb = new ViewBooks();
                vb.Show();
            }
            finally
            {
                viewBooksToolStripMenuItem.Enabled = true;
            }
            
        }

      

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMemberToolStripMenuItem.Enabled = false;

            try
            {
                AddMember arm = new AddMember();
                arm.Show();

            }
            finally
            {
                addMemberToolStripMenuItem.Enabled = true;
            }


        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            viewMembersToolStripMenuItem.Enabled = false;
            try
            {

                ViewMember vm = new ViewMember();
                vm.Show();
            }
            finally
            {
                viewMembersToolStripMenuItem.Enabled = true;
            }


        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

            updateMemberToolStripMenuItem.Enabled = false;
            try
            {

                UpdateMember um = new UpdateMember();
                um.Show();
            }
            finally
            {
                updateMemberToolStripMenuItem.Enabled = true;
            }


        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeBookToolStripMenuItem.Enabled = false;
            try
            {
                RemoveBook rb = new RemoveBook();
                rb.Show();
            }
            finally
            {
                removeBookToolStripMenuItem.Enabled = true;
            }



        }

        private void borrowingToolStripMenuItem_Click(object sender, EventArgs e)// Ik heb het geprobeerd te verwijderen via de Events, maar is mij niet gelukt.Ik heb het trouwens meermaals op die manier gedaan en toen is het wel gelukt, maar hier niet.
        {

        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrowBookToolStripMenuItem.Enabled = false;
            try
            {

                BorrowBook br = new BorrowBook();
                br.Show();
            }
            finally
            {
                borrowBookToolStripMenuItem.Enabled = true;
            }


        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnBookToolStripMenuItem.Enabled = false;
            try
            {
                ReturnBook bk = new ReturnBook();
                bk.Show();
            }
            finally
            {
                returnBookToolStripMenuItem.Enabled = true;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)// Ik heb het geprobeerd te verwijderen via de Events, maar is mij niet gelukt. Ik heb het trouwens meermaals op die manier gedaan en toen is het wel gelukt, maar hier niet.
        {


        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            exitToolStripMenuItem.Enabled = false;
            try
            {
                Application.Exit();
            }
            finally
            {
                exitToolStripMenuItem.Enabled = true;
            }

        }

        private void removeMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeMemberToolStripMenuItem.Enabled = false;
            try
            {
                RemoveMember rm = new RemoveMember();
                rm.Show();
            }
            finally
            {
                removeMemberToolStripMenuItem.Enabled = true;
            }

        }
    }
}
