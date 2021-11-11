using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{

    class Book : BookRepository
    {

        public int? Isbn { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string StatusBook { get; set; }


        public enum Status
        {
            Available,
            Borrowed
        }

        public Book()
        {

        }

        public Book(int isbn)
        {
            Isbn = isbn;
        }

        public Book(string title, string edition, string author, string genre)
        {
            Title = title;
            Edition = edition;
            Author = author;
            Genre = genre;
            StatusBook = Status.Available.ToString();

        }

    }
}
