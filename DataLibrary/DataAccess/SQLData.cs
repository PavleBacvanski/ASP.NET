using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess 
{
    public class SQLData
    {
        public static List<ProductModel> ShowProducts()
        {
            string sql = @"select naziv, opis, kategorija, proizvodjac, dobavljac, cena
                           from dbo.Proizvod";

            return DataAccess.SQLDataAccess.LoadData<ProductModel>(sql);
        }
    }
}
