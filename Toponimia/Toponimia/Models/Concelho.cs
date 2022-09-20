using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Toponimia.Models
{
    public class Concelho
    {
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Designacao { get; set; }
        public Distrito Distrito { get; set; }
    }
}
