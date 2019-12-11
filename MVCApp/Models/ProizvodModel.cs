using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class ProizvodModel
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Kategorija { get; set; }
        public string Proizvodjac { get; set; }
        public string Dobavljac { get; set; }
        public string Cena { get; set; }

    }
}