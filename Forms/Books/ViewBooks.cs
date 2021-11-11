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
    public partial class ViewBooks : Form
    {
        BookRepository br = new BookRepository();

        public ViewBooks()
        {
            InitializeComponent();
        }



        private void setDataGridView(SqlCommand command)
        {

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewBook.DataSource = dt;
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            
            setDataGridView(br.GetCommandForAllBooks());
        }


       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;

            try
            {

             
                setDataGridView(br.GetCommandForBook(int.Parse(txtSearchIsbn.Text)));
                
            }

            finally
            {

                btnSearch.Enabled = true;
            }

           
        }

        private void btnGetAll_Click(object sender, EventArgs e)// effacer ce qui est dans le txt
        {
            

            setDataGridView(br.GetCommandForAllBooks());

        }
    }
}
