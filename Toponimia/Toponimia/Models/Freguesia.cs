using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Toponimia.Models
{
    public class Freguesia
    {
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Designacao { get; set; }
        public Concelho Concelho { get; set; }
    }
}
