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
    public partial class AddBook : Form
    {
        string conn = "Data Source=(local);Initial Catalog=Library;Integrated Security=True";

      

        public AddBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            using SqlConnection connection = new SqlConnection(conn);

            var command = connection.CreateCommand();

            command.CommandText = "insert into [TableBook] (Title, Edition, Author, Genre) Values (@Title, @Edition, @Author, @Genre); select scope_identity()";
            command.Parameters.AddWithValue("@Title", txtTitle.Text);
            command.Parameters.AddWithValue("@Edition", txtEdition.Text);
            command.Parameters.AddWithValue("@Author", txtAuthor.Text);
            command.Parameters.AddWithValue("@Genre", txtGenre.Text);


            using var reader = command.ExecuteReader();// la connection avec le server ne se fait pas.
            reader.Read();

           

            MessageBox.Show("The book has been added");

        }

        private void btnRemove_Click(object sender, EventArgs e)// ik krijg het niet weg 
        {
            
        }
    }
}

