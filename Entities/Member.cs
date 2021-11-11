using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{


    class Member : BookRepository
    {

        public int? Member_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string HouseNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public int Phone_Number { get; set; }
        public string Mail { get; set; }


        public Member(int member_id)
        {
            Member_id = member_id;
        }
        public Member(string firstname, string lastname, string address, string houseNumber, int zipCode, string city, int phoneNumber, string mail)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            HouseNumber = houseNumber;
            ZipCode = zipCode;
            City = city;
            Phone_Number = phoneNumber;
            Mail = mail;
        }
        public Member()
        {

        }


    }
}
