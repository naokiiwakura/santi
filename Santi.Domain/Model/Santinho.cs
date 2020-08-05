using Santi.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Santi.Domain.Model
{
    public class Santinho : EntityBase
    {
        public virtual Candidato Candidato { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
    }
}
