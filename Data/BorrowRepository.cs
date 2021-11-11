using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library
{
    class BorrowRepository : IDisposable
    {

        protected readonly SqlConnection _connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");

        public BorrowRepository()
        {

            _connection.Open();
        }


        public Borrow AddBorrowedBook(Borrow book)
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "insert into [TableBorrows] (Isbn, Member_Id, Purchase_Date, Return_Date) Values (@Isbn, @Member_Id, @Purchase_Date, @Return_Date);";
            command.Parameters.AddWithValue("@Isbn", book.Isbn);
            command.Parameters.AddWithValue("@Member_Id", book.Member_Id);
            command.Parameters.AddWithValue("@Purchase_Date", book.CurrentDate);
            command.Parameters.AddWithValue("@Return_Date", book.ReturnDate);
            command.ExecuteNonQuery();

            return book;

        }


        public void UpdateBorrowedBook(int isbn)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE  [TableBook] SET [Status]=@Status where [Isbn]= @Isbn";
            command.Parameters.AddWithValue("@Isbn", isbn);
            command.Parameters.AddWithValue("@Status", "Borrowed");
            command.ExecuteNonQuery();

        }



        public void DeleteBorrowedBook(int isbn)
        {

            using var command = _connection.CreateCommand();

            command.CommandText = "DELETE FROM [TableBorrows] where Isbn=@Isbn;";
            command.Parameters.AddWithValue("@Isbn", isbn);
            command.ExecuteNonQuery();

        }

        public void UpdateAvailableBook(int isbn)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE [TableBook] SET [Status]=@Status WHERE Isbn = @Isbn";
            command.Parameters.AddWithValue("@Isbn", isbn);
            command.Parameters.AddWithValue("@Status", "Available"); //Book.Status.Available.ToString()
            command.ExecuteNonQuery();

        }

        public SqlCommand GetAllBorrowedBook()
        {
            using var command = _connection.CreateCommand();

            command.CommandText = " select * from [TableBorrows]";

            return command;
        }

     




        /* Ik heb het volgende geprobeerd zoals je mij had aangeraden, maar het is mij niet gelukt. Ik ben dus terug gegaan naar de code die werkte, maar waarschijnlijk gebreken heeft.
         * 

        public Borrow BorrowBook(Borrow book)
        {

            void Insert(SqlTransaction transaction)
            {

                using var command = _connection.CreateCommand();

                command.CommandText = "insert into [TableBorrows] (Isbn, Member_Id, Status, Purchase_Date, Return_Date) Values (@Isbn, @Member_Id, @Status, @Purchase_order, @Return_Date);";
                command.Transaction = transaction;
                command.Parameters.AddWithValue("@Isbn", book.Isbn);
                command.Parameters.AddWithValue("@Member_Id", book.Member_Id);
                command.Parameters.AddWithValue("@Purchase_Date", book.CurrentDate);
                command.Parameters.AddWithValue("@Return_Date", book.ReturnDate);

                command.ExecuteNonQuery();
            }

            void Update(SqlTransaction transaction)
            {
                using var command = _connection.CreateCommand();
                command.Transaction = transaction;
                command.CommandText = "UPDATE  [TableBook] SET [Status]=@Status where [Isbn]= @Isbn";
                command.Parameters.AddWithValue("@Isbn", book.Isbn);
                command.Parameters.AddWithValue("@Status", "Borrowed");
                command.ExecuteNonQuery();

            }

            using var transaction = _connection.BeginTransaction();
            try
            {
                Insert(transaction);
                Update(transaction);
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
           
            return book;
        }


        public void ReturnBook(int isbn)
        {

            void Delete(SqlTransaction transaction)
            {

                using var command = _connection.CreateCommand();
                command.Transaction = transaction;
                command.CommandText = "DELETE FROM [TableBorrows] where Isbn=@Isbn;";
                command.Parameters.AddWithValue("@Isbn", isbn);


                command.ExecuteNonQuery();

            }

            void Update(SqlTransaction transaction)
            {
                using var command = _connection.CreateCommand();
                command.Transaction = transaction;
                command.CommandText = "UPDATE [TableBook] SET [Status]=@Status WHERE Isbn = @Isbn";
                command.Parameters.AddWithValue("@Isbn", isbn);
                command.Parameters.AddWithValue("@Status", "Available"); //Book.Status.Available.ToString()
                command.ExecuteNonQuery();

            }

            using var transaction = _connection.BeginTransaction();
            try
            {
                Delete(transaction);
                Update(transaction);
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }


           
        }
         * 
         */




        public void Dispose()
        {
            _connection.Close();
        }
    }
}
