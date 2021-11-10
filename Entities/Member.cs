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
        public int HouseNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public int Phone_Number { get; set; }
        public string Mail { get; set; }
        

        public Member(int member_id)
        {
            Member_id = member_id;
        }
        public Member(string firstname, string lastname, string address, int houseNumber, int zipCode, string city, int phoneNumber, string mail)
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

        public Member AddMember()
        {
            using var command = _connection.CreateCommand();

            command.CommandText = "insert into [TableMember] (FirstName, LastName, Address, HouseNumber, ZipCode, City, Phone_number, Mail ) Values (@FirstName, @LastName, @Address, @HouseNumber, @ZipCode, @City, @Phone_number, @Mail); select scope_identity()";
            command.Parameters.AddWithValue("@FirstName", this.FirstName);
            command.Parameters.AddWithValue("@LastName", this.LastName);
            command.Parameters.AddWithValue("@Address", this.Address);
            command.Parameters.AddWithValue("@HouseNumber", this.HouseNumber);
            command.Parameters.AddWithValue("@ZipCode", this.ZipCode);
            command.Parameters.AddWithValue("@City", this.City);
            command.Parameters.AddWithValue("@Phone_number", this.Phone_Number);
            command.Parameters.AddWithValue("@Mail", this.Mail);

            using var reader = command.ExecuteReader();
            reader.Read();
            this.Member_id = (int)reader.GetDecimal(0);
            MessageBox.Show($"The Member with the id {Member_id} has been added");

            return this;
        }

        public void RemoveMember()
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM [TableMember] where Member_Id= '" + this.Member_id+ "'; select scope_identity()";
            using var reader = command.ExecuteReader();
            reader.Read();
            this.Member_id = (int)reader.GetDecimal(0);
            command.ExecuteNonQuery();

            MessageBox.Show($"The member with the ID {Member_id} has been removed");
        }

        public void UpdateMember()
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE [TableMember] SET [FirstName]=@FirstName, [LastName]=@LastName, [Address]=@Address, [HouseNumber]=@HouseNumber, [ZipCode]=@ZipCode, [City]=@City, [Phone_number]=@Phone_number, [Mail]=@Mail) WHERE Member_id='" + this.Member_id + "'";
            command.Parameters.AddWithValue("@LastName", this.LastName);
            command.Parameters.AddWithValue("@Address", this.Address);
            command.Parameters.AddWithValue("@HouseNumber", this.HouseNumber);
            command.Parameters.AddWithValue("@ZipCode", this.ZipCode);
            command.Parameters.AddWithValue("@City", this.City);
            command.Parameters.AddWithValue("@Phone_number", this.Phone_Number);
            command.Parameters.AddWithValue("@Mail", this.Mail);

            command.ExecuteNonQuery();
        }

        public Member SearchMember()
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "select from [TableMember] where Member_Id='" + this.Member_id + "'; select scope_identity()";

            using var reader = command.ExecuteReader();
            reader.Read();
            this.Member_id= (int)reader.GetDecimal(0);

            return this;
        }


    }
}
