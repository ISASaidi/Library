using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Library
{
    class BookRepository : IDisposable
    {
        protected readonly SqlConnection _connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");

        public BookRepository()
        {

            _connection.Open();
        }

        public Book AddBook(Book book)
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "insert into [TableBook] (Title, Edition, Author, Genre, Status) Values (@Title, @Edition, @Author, @Genre, @Status); select scope_identity()";
            command.Parameters.AddWithValue("@Title", book.Title);
            command.Parameters.AddWithValue("@Edition", book.Edition);
            command.Parameters.AddWithValue("@Author", book.Author);
            command.Parameters.AddWithValue("@Genre", book.Genre);
            command.Parameters.AddWithValue("@Status", book.StatusBook);

            using var reader = command.ExecuteReader();
            reader.Read();
            MessageBox.Show("The book has been added");

            book.Isbn = (int)reader.GetDecimal(0);

            return book;
        }

        public void RemoveBook(int Isbn)
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM [TableBook] where Isbn= @Isbn";
            command.Parameters.AddWithValue("@Isbn", Isbn);
            command.ExecuteNonQuery();
            MessageBox.Show("The book has been removed");
        }

        public void UpdateBook(Book book, string status, int isbn)
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE [TableBook] SET [Title]=@Title, [Edition]=@Edition, [Author]=@Author, [Genre]=@Genre, [Status]=@Status WHERE [Isbn]= @Isbn";

            command.Parameters.AddWithValue("@Isbn", isbn);
            command.Parameters.AddWithValue("@Title", book.Title);
            command.Parameters.AddWithValue("@Edition", book.Edition);
            command.Parameters.AddWithValue("@Author", book.Author);
            command.Parameters.AddWithValue("@Genre", book.Genre);
            command.Parameters.AddWithValue("@Status", status);
            command.ExecuteNonQuery();


        }


        public SqlCommand GetCommandForBook(int isbn)
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "select * from [TableBook] where Isbn= @Isbn;select scope_identity()";
            command.Parameters.AddWithValue("@Isbn", isbn);



            return command;


        }

        public SqlCommand GetCommandForAllBooks()
        {
            

            var command = _connection.CreateCommand();
            command.CommandText = "select * from [TableBook]";

            return command;

           
        }

        public void Dispose()
        {
            _connection.Close();
        }
    }
}
