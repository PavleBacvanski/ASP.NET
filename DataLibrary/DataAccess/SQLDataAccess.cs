﻿using System;
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
        public static string GetConnString(string connName = "MyConnection")
        {
            return ConfigurationManager.ConnectionStrings[connName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using(IDbConnection conn = new SqlConnection(GetConnString()))
            {
                return conn.Query<T>(sql).ToList();
            }
        }

    }
}