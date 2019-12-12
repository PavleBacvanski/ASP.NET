using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.DataAccess
{
    public static class SQLDataAccess
    {
        //Conn String
        public static string GetConnString()
        {
            return ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        //Show data
        public static List<T> LoadData<T>(string sql)
        {
            using(IDbConnection conn = new SqlConnection(GetConnString()))
            {
                return conn.Query<T>(sql).ToList();
            }
        }

        //Create/Update
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection conn = new SqlConnection(GetConnString()))
            {
                return conn.Execute(sql, data);
            }
        }

    }
}
