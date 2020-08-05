using Santi.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Model
{
    public class Colinha : EntityBase
    {
        public virtual Candidato Candidato { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}