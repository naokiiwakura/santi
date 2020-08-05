using Santi.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Model
{
    public class Filiacao : EntityBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<PartidoFiliacao> Partidos { get; set; }
    }
}
