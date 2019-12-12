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
        public static string GetJson()
        {
            string path = @"C:\Users\Aorus Pro\source\repos\WirelessMedia\DataLibrary\DataAccess\TechJson.json";

            StreamReader reader = new StreamReader(path);
            return reader.ReadToEnd();
        }
    }
}
