using DBLayer;
using RiziBizi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiziBizi;
using RiziBizi.Repositories;
using RiziBizi.Properties;
using System.Data.SqlClient;

namespace RiziBizi.Repositories
{
    public class CRUDRepository
    {
        public static CRUD GetCRUD(Recenzija recenzija, Narudžbe narudžbe)
        {

            CRUD crud = null;
            string sql = $"SELECT * FROM CRUD WHERE IdRecenzija = {recenzija.Id} AND IdNarudžbe = {narudžbe.Id} ";


            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                crud = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return crud;

        }
        public static List<CRUD> GetCRUD(Recenzija recenzija)
        {
            List<CRUD> crud = new List<CRUD>();
            string sql = $"SELECT * FROM CRUD WHERE NazivRecenzija = {recenzija.Naziv}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                CRUD cruds = CreateObject(reader);
                crud.Add(cruds);
            }
            reader.Close();
            DB.CloseConnection();
            return crud;
        }
        private static CRUD CreateObject(SqlDataReader reader)
        {
            int idNarudžbe = int.Parse(reader["IdNarudžbe"].ToString());
            var narudžbe = NarudžbeRepository.GetNarudžbe(idNarudžbe);
            int Recenzija = int.Parse(reader["IdRecenzija"].ToString());

            int ocjena = int.Parse(reader["Ocjena"].ToString());
            var crud = new CRUD

            {
                Narudžbe = narudžbe,

                Ocjena = ocjena
            };
            return crud;
        }
    }
}