using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess
{
    public class JsonData
    {
        //Putanja do json file
        public static string GetJson()
        {
            string subfoldername = "Json";
            string filename = "TechJson.json";

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, subfoldername, filename);

            StreamReader reader = new StreamReader(path);
            return reader.ReadToEnd();
        }
    }
}
