using Intro.API.Model;
using System.Data;
using System.Data.SqlClient;

namespace Intro.API.Database
{
    public class DatabaseManager : IDatabaseManager
    {
        private SqlConnection _conn;
        private IConfiguration _conf;
        public DatabaseManager(IConfiguration conf)
        {
            _conf = conf;
            _conn = new SqlConnection(_conf.GetConnectionString("DB"));
        }
        public bool AddIngredient(Ingredient ing)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetAllIngredients()
        {
            List<Ingredient> lstIng = new List<Ingredient>();
            _conn.Open();
            SqlCommand cmd = new SqlCommand("usp_GetAllIngredients", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Ingredient ing = new Ingredient();
                ing.Id = rdr["ID"] != null ? Convert.ToString(rdr["ID"]) : "";
                ing.Name = rdr["NAME"] != null ? Convert.ToString(rdr["NAME"]) : "";
                lstIng.Add(ing);
            }
            _conn.Close();
            return lstIng;
        }
    }
}
