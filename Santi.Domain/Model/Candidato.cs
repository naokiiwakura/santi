using Santi.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Model
{
    public class Candidato : EntityBase
    {
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public int Numero { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Foto { get; set; }
        public int PartidoId { get; set; }
        public virtual Partido Partido { get; set; }
        public virtual ICollection<Colinha> Colinhas { get; set; }
        public virtual ICollection<Santinho> Santinhos { get; set; }
    }
}
