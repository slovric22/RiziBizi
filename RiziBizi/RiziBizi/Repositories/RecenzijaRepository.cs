using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiziBizi.Models;
using DBLayer;
using System.Diagnostics;
using RiziBizi.Repositories;


namespace RiziBizi.Repositories
{

    public class RecenzijaRepository
    {

        public Recenzija GetRecenzija(int id)
        {
            Recenzija recenzija = null;
            string sql = $"SELECT * FROM Recenzija WHERE ID = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                recenzija = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return recenzija;
        }


        public static List<Recenzija> GetRecenzija()
        {
            List<Recenzija> recenzije = new List<Recenzija>();
            string sql = "SELECT * FROM Recenzija";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Recenzija narudžbe = CreateObject(reader);
                recenzije.Add(narudžbe);
            }
            reader.Close();
            DB.CloseConnection();
            return recenzije;
        }

        public static void SaveRecenzije(Recenzija recenzija)
        {
            string sql = "";
            DB.OpenConnection();
            if (recenzija.Id == 0)
            {
                sql = $"INSERT INTO Recenzija (Ocjena, Komentar) VALUES ('{recenzija.Ocjena}', '{recenzija.Komentar}')";
            }
            else
            {
                sql = $"UPDATE Recenzija SET Ocjena = '{recenzija.Ocjena}', Komentar = '{recenzija.Komentar}'";
            }
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteRecenzija(Recenzija recenzija)
        {
            string sql = "DELETE FROM Recenzija WHERE Id = " + recenzija.Id;
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<Recenzija> FilterByUsername(string username)
        {
            List<Recenzija> recenzije = new List<Recenzija>();
            string sql = $"SELECT * FROM Recenzija WHERE Username = '{username}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Recenzija narudžbe = CreateObject(reader);
                recenzije.Add(narudžbe);
            }
            reader.Close();
            DB.CloseConnection();
            return recenzije;
        }


        private static Recenzija CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string komentar = reader["Komentar"].ToString();
            string username = reader["Username"].ToString();
            string ocjena = reader["Ocjena"].ToString();

            var recenzija = new Recenzija
            {
                Id = id,
                Komentar = komentar,
                Username = username,
                Ocjena = ocjena
            };
            return recenzija;
        }
        public static void Create(Recenzija recenzija)
        {
            string sql = $"INSERT INTO Recenzija (Id, Komentar, Username , Ocjena) " +
                         $"VALUES ('{recenzija.Id}', '{recenzija.Komentar}', {recenzija.Username}, '{recenzija.Ocjena}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}