using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library.Entities
{
    class Book
    {

        public int? Isbn { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public Status StatusBook { get; set; }

        public enum Status
        {
            Free=0,
            Borrowed=1
        }

        public Book()
        {
          //  Title = txtTitle.Text; => ik wil alle waarden van de formulier zo doorgeven aan mijn eigenschappen, maar dat lukt niet.
        }
    }
}
