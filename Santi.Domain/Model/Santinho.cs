using Santi.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Santi.Domain.Model
{
    public class Santinho : EntityBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Foto { get; set; }
        public int CandidatoId { get; set; }
        [ForeignKey("CandidatoId")]
        public virtual Candidato Candidato { get; set; }
    }
}
