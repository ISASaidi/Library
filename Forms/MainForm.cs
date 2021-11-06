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
            Add_Remove_Book ab = new Add_Remove_Book();
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

        private void borrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrowing_Returning br = new Borrowing_Returning();
            br.Show();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
