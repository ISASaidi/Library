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
    public partial class RemoveBook : Form
    {
        BookRepository br = new BookRepository();
        public RemoveBook()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            try
            {
                
                br.RemoveBook(int.Parse(txtIsbn.Text));
            }
            finally
            {
                btnRemove.Enabled = true;

            }

        }
    }
}
