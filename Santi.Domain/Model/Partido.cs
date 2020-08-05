using Santi.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Model
{
    public class Partido : EntityBase
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Logo { get; set; }
        public virtual ICollection<PartidoFiliacao> Filiacoes { get; set; }
        public virtual ICollection<Candidato> Candidatos { get; set; }
    }
}
