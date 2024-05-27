using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiziBizi.Models;
using RiziBizi;
namespace RiziBizi.Repositories
{
    public class StudentRepository 
    {
        public static Student GetStudent(string username)
        {
            string sql = $"SELECT * FROM Student WHERE Username = '{username}'";
            return FetchStudent(sql);
        }
        public static Student GetStudent(int id)
        {
            string sql = $"SELECT * FROM Student WHERE Id = {id}";
            return FetchStudent(sql);
        }
        private static Student FetchStudent(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Student student = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return student;
        }
        private static Student CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            
            string ime = reader["Ime"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            var student = new Student
            {
                Id = id,
                Ime = ime,
                Lozinka = lozinka
            };
            return student;
        }

    }
}
