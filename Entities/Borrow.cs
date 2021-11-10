using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    class Borrow : BookRepository
    {

        public int Identification { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Borrow(int isbn, int memberId, DateTime currentDate, DateTime returnDate)
        {
            Book.Isbn = isbn;
            Member.Member_id = memberId;
            CurrentDate = currentDate;
            ReturnDate = returnDate;

        }

        public Borrow(int isbn)
        {
            Book.Isbn = isbn;
        }



        public Borrow BorrowBook()
        {

            void Insert(SqlTransaction transaction)
            {

                using var command = _connection.CreateCommand();

                command.CommandText = "insert into [TableBorrows] (Isbn, Member_Id, Status, Purchase_Date, Return_Date) Values (@Isbn, @Member_Id, @Status, @Purchase_order, @Return_Date);";
                command.Transaction = transaction;
                command.Parameters.AddWithValue("@Isbn", this.Book.Isbn);
                command.Parameters.AddWithValue("@Member_Id", this.Member.Member_id);
                command.Parameters.AddWithValue("@Purchase_Date", CurrentDate);
                command.Parameters.AddWithValue("@Return_Date", ReturnDate);

                command.ExecuteNonQuery();
            }

            void Update(SqlTransaction transaction)
            {
                using var command = _connection.CreateCommand();
                command.Transaction = transaction;
                command.CommandText = "UPDATE  [TableBook] SET [Status]=@Status where [Isbn]= @Isbn";
                command.Parameters.AddWithValue("@Isbn", this.Book.Isbn);
                command.Parameters.AddWithValue("@Status", Book.Status.Borrowed.ToString());
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
            MessageBox.Show("The book has been borrowed");
            return this;
        }


        public void ReturnBook()
        {

            void Delete(SqlTransaction transaction)
            {

                using var command = _connection.CreateCommand();
                command.Transaction = transaction;
                command.CommandText = "DELETE FROM [TableBorrows] where Isbn=@Isbn;";
                command.Parameters.AddWithValue("@Isbn", this.Book.Isbn);
               

                command.ExecuteNonQuery();

            }

            void Update(SqlTransaction transaction)
            {
                using var command = _connection.CreateCommand();
                command.Transaction = transaction;
                command.CommandText = "UPDATE [TableBook] SET [Status]=@Status WHERE Isbn = @Isbn";
                command.Parameters.AddWithValue("@Isbn", this.Book.Isbn);
                command.Parameters.AddWithValue("@Status", Book.Status.Available.ToString());
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


            MessageBox.Show("The book has been returned");
        }
    }
}
