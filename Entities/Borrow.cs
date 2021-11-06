using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    class Borrow
    {
        public int Identification { get; set; }
        public int Isbn { get; set; }
        public int Member_id { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime ReturnDate { get; set; }
       
    }

  
}
