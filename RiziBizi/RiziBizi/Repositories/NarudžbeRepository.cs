using DBLayer;
using RiziBizi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiziBizi.Repositories
{
    
    

        public class NarudžbeRepository
        {

            
            public static Narudžbe GetNarudžbe(string naziv)
            {
            
                string sql = $"SELECT * FROM Narudžbe WHERE Naziv = '{naziv}'";
            return FetchNarudžbe(sql);
        }

            
            public static Narudžbe GetNarudžbe(int id)
            {
                string sql = $"SELECT * FROM Administrators WHERE ID_administrator = {id}";
                return FetchNarudžbe(sql);
            }

            private static Narudžbe FetchNarudžbe(string sql)
            {
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                Narudžbe narudžbe = null;
                if (reader.HasRows)
                {
                    reader.Read();
                    narudžbe = CreateObject(reader);
                    reader.Close();
                }
                DB.CloseConnection();
                return narudžbe;
            }

            public static List<Narudžbe> GetNarudžbe()
            {
                List<Narudžbe> narudžbe = new List<Narudžbe>();
                string sql = "SELECT * FROM Narudžbe";
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                while (reader.Read())
                {
                    Narudžbe narudžba = CreateObject(reader);
                    narudžbe.Add(narudžba);
                }
                reader.Close();
                DB.CloseConnection();
                return narudžbe;
            }

            private static Narudžbe CreateObject(SqlDataReader reader)
            {
                int id = int.Parse(reader["ID_narudžbe"].ToString());
                string naziv = reader["Naziv"].ToString();
                string sastojci = reader["Sastojci"].ToString();
                
                var narudžbe = new Narudžbe
                {
                    Id = id,
                    Naziv = naziv,
                    Sastojci = sastojci
                    
                };
                return narudžbe;
            }
        }
    }

