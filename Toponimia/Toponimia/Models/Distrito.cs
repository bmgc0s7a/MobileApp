using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Toponimia.Models
{
    public class Distrito
    {
        //Nota: O Id vai ser um GUID (Global Unique Identifier)
        //xxxxxxxx-xxxx-xxxx-xxxxxxxxxxxx


        [PrimaryKey]
        public Guid Id { get; set; }
        public string Designacao { get; set; }
    }
}
