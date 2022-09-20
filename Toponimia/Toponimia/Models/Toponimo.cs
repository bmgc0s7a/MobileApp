using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Toponimia.Models
{
    public class Toponimo
    {
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Designacao { get; set; }
        public Freguesia Freguesia { get; set; }

        public int Topo_Inicio { get; set; }
        public int Topo_Fim { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public Tipo_Arruamento Tipo_Arruamento { get; set; }

        public double Extensao { get; set; }

        public double Area { get; set; }

        public string Observacoes { get; set; }


    }
}
