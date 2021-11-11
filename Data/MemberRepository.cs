using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library
{
    class MemberRepository
    {
        protected readonly SqlConnection _connection = new SqlConnection("Data Source=(local);Initial Catalog=Library;Integrated Security=True");

        public MemberRepository()
        {

            _connection.Open();
        }


        public Member AddMember(Member member)
        {
            using var command = _connection.CreateCommand();

            command.CommandText = "insert into [TableMember] (FirstName, LastName, Address, HouseNumber, ZipCode, City, Phone_number, Mail ) Values (@FirstName, @LastName, @Address, @HouseNumber, @ZipCode, @City, @Phone_number, @Mail)";
            command.Parameters.AddWithValue("@FirstName", member.FirstName);
            command.Parameters.AddWithValue("@LastName", member.LastName);
            command.Parameters.AddWithValue("@Address", member.Address);
            command.Parameters.AddWithValue("@HouseNumber", member.HouseNumber);
            command.Parameters.AddWithValue("@ZipCode", member.ZipCode);
            command.Parameters.AddWithValue("@City", member.City);
            command.Parameters.AddWithValue("@Phone_number", member.Phone_Number);
            command.Parameters.AddWithValue("@Mail", member.Mail);

            command.ExecuteNonQuery();

            return member;
        }

        public void RemoveMember(int member_id)// Truncate?
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM [TableMember] where Member_Id=@Member_Id";
            command.Parameters.AddWithValue("@Member_Id", member_id);
            command.ExecuteNonQuery();

        }


        public void UpdateMember(Member member, int member_id)// verifier que phonenumber est un int et pas trop long. Verifier que le member_id existe, vérifier que le zipcode est un int
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE [TableMember] SET [FirstName]=@FirstName, [LastName]=@LastName, [Address]=@Address, [HouseNumber]=@HouseNumber, [ZipCode]=@ZipCode, [City]=@City, [Phone_number]=@Phone_number, [Mail]=@Mail WHERE Member_id=@Member_id";
            command.Parameters.AddWithValue("@Member_id", member_id);
            command.Parameters.AddWithValue("@FirstName", member.FirstName);
            command.Parameters.AddWithValue("@LastName", member.LastName);
            command.Parameters.AddWithValue("@Address", member.Address);
            command.Parameters.AddWithValue("@HouseNumber", member.HouseNumber);
            command.Parameters.AddWithValue("@ZipCode", member.ZipCode);
            command.Parameters.AddWithValue("@City", member.City);
            command.Parameters.AddWithValue("@Phone_number", member.Phone_Number);
            command.Parameters.AddWithValue("@Mail", member.Mail);

            command.ExecuteNonQuery();
        }

        public SqlCommand GetCommandFindMember(int member_id)
        {

            using var command = _connection.CreateCommand();
            command.CommandText = "select * from [TableMember] where Member_Id=@Member_Id ";
            command.Parameters.AddWithValue("@Member_id", member_id);

            return command;
        }

        public SqlCommand GetCommandForAllMembers()
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "select * from [TableMember]";

            return command;
        }

        public void Dispose()
        {
            _connection.Close();
        }
    }
}
