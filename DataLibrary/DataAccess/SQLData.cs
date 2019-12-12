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
        //Prikaz liste proizvoda
        public static List<ProductModel> ShowProducts()
        {
            string sql = @"select naziv, opis, kategorija, proizvodjac, dobavljac, cena
                           from dbo.Proizvod";

            return DataAccess.SQLDataAccess.LoadData<ProductModel>(sql);
        }

        //kreiranje novog proizvoda
        public static int CreateProduct(string naziv, string opis, string kategorija,
            string proizvodjac, string dobavljac, string cena)
        {
            ProductModel data = new ProductModel
            {
                Naziv = naziv,
                Opis = opis,
                Kategorija = kategorija,
                Proizvodjac = proizvodjac,
                Dobavljac = dobavljac,
                Cena = cena
            };

            string sql = @"insert into dbo.Proizvod (naziv, opis, kategorija, proizvodjac, dobavljac, cena)
                        values (@Naziv, @Opis, @Kategorija, @Proizvodjac, @Dobavljac, @Cena);";

            return SQLDataAccess.SaveData(sql, data);
        }

        //Izmena
        public static int UpdateProduct(string naziv, string opis, string kategorija,
            string proizvodjac, string dobavljac, string cena)
        {
            ProductModel data = new ProductModel
            {
                Naziv = naziv,
                Opis = opis,
                Kategorija = kategorija,
                Proizvodjac = proizvodjac,
                Dobavljac = dobavljac,
                Cena = cena
            };

            string sql = @"update dbo.Proizvod
                        set naziv = @Naziv, opis = @Opis, kategorija = @Kategorija,
                        proizvodjac = @Proizvodjac, dobavljac = @Dobavljac, cena = @Cena
                        where naziv = @Naziv;";

            return SQLDataAccess.SaveData(sql, data);
        }
    }
}
