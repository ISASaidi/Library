using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

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
            btnSave.Enabled = false;// Waar moet ik het plaatsen
            Thread.Sleep(1000);
            btnSave.Enabled = true;
            //Entities.Book bk = new Entities.Book();

            using SqlConnection connection = new SqlConnection("Data Source=MOHAMED-DESKTOP;Initial Catalog=Library;Integrated Security=True");

            var command = connection.CreateCommand();
            command.CommandText = "UPDATE [TableBook] SET ([Title]=@Title, [Edition]=@Edition, [Author]=@Author, [Genre]=@Genre, [Status]=@Status) WHERE [Isbn]= '"+txtIsbn.Text+"'";

            command.Parameters.AddWithValue("@Title", txtTitle.Text); //bk.Title
            command.Parameters.AddWithValue("@Edition", txtEdition.Text); // bk.Edition
            command.Parameters.AddWithValue("@Author", txtAuthor.Text); //bk.Author
            command.Parameters.AddWithValue("@Genre", txtGenre.Text); //bk.Genre

            if (comboBoxStatus.SelectedIndex == 0)
            {
                command.Parameters.AddWithValue("@Status", "Borrowed");// Entities.Book.Status.Borrowed.ToString()
            }
            else
            {
                command.Parameters.AddWithValue("@Status", "Free");//Entities.Book.Status.Free.ToString()
            }
                      command.ExecuteNonQuery();
        }

    }
}

