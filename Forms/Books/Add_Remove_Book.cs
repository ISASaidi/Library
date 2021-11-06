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
    public partial class Add_Remove_Book : Form
    {
        string conn = "@Data Source=(local);Initial Catalog=Library;Integrated Security=True";

      

        public Add_Remove_Book()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            using SqlConnection connection = new SqlConnection(conn);

            using var command = connection.CreateCommand();

            command.CommandText = "insert into [TableBook] (Title, Edition, Author, Genre) Values (@Title, @Edition, @Author, @Genre); select scope_identity()";
            command.Parameters.AddWithValue("@Title", txtTitle.Text);
            command.Parameters.AddWithValue("@Edition", txtEdition.Text);
            command.Parameters.AddWithValue("@Author", txtAuthor.Text);
            command.Parameters.AddWithValue("@Genre", txtGenre.Text);


            using var reader = command.ExecuteReader();// la connection avec le server ne se fait pas.
            reader.Read();

           

            MessageBox.Show("The book has been added");

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(conn);

            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM [TableBook] where Title= '"+txtTitle.Text+"'";// Je devrais le faire avec le ISBN. Je sais que ce n'est pas top, mais si je touche à quelque chose après c'est la misère pour qu'il ouvre mon formulaire sans erreur
            using var reader = command.ExecuteReader(); // la connection avec le server ne se fait pas.
            reader.Read();
            MessageBox.Show("The book has been removed"); 
        }
    }
}