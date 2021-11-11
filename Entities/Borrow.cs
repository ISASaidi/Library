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
        public int Isbn { get; set; }
        public int Member_Id { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Borrow(int isbn, int memberId, DateTime currentDate, DateTime returnDate)
        {
            Isbn = isbn;
            Member_Id = memberId;
            CurrentDate = currentDate;
            ReturnDate = returnDate;

        }

        public Borrow(int isbn)
        {
            Isbn = isbn;
        }




    }
}
