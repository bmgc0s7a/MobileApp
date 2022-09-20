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

        //CRIAÇÃO DE UM OBJETO TOPÓNIMO "INLINE"
        //Models.Toponimo teste = new Models.Toponimo
        //{
        //    Id = Guid.NewGuid(),
        //    Designacao = "Rua de Cima",
        //    Freguesia = new Models.Freguesia
        //    {
        //        Id = Guid.NewGuid(),
        //        Designacao = "Freguesia de Nossa Senhora da Ajuda",
        //        Concelho = new Models.Concelho
        //        {
        //            Id = Guid.NewGuid(),
        //            Designacao = "Vila Nova de Gaia",
        //            Distrito = new Models.Distrito
        //            {
        //                Id = Guid.NewGuid(),
        //                Designacao = "Porto"
        //            }
        //        }
        //    }
        //};
    }
}
