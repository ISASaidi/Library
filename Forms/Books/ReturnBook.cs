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

namespace Library
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnReturn.Enabled = false;

            try
            {
                Borrow brw = new Borrow(int.Parse(txtIsbn.Text));
                brw.ReturnBook();
            }
            finally
            {
                btnReturn.Enabled = true;
            }

        }
    }
}
