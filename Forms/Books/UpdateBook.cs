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
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");

            var command = connection.CreateCommand();
            command.CommandText = "UPDATE [TableBook] SET [Title]=@Title, [Edition]=@Edition, [Author]=@Author, [Genre]=@Genre, [Borrowed]=@Borrowed";

            command.Parameters.AddWithValue("@Title", txtTitle.Text);
            command.Parameters.AddWithValue("@Edition", txtEdition.Text);
            command.Parameters.AddWithValue("@Author", txtAuthor.Text);
            command.Parameters.AddWithValue("@Genre", txtGenre.Text);
            command.Parameters.AddWithValue("@Borrowed", checkBoxBorrowed.Text);// comment je fais pour envoyer la valeur à mon server. je veux que quand ce soit unchecked il y a 0 dans mon database et quand c'est checked 1
            command.ExecuteNonQuery();
        }

    }
}

