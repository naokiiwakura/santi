using Santi.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Model
{
    public class PartidoFiliacao : EntityBase
    {
        public virtual Partido Partido { get; set; }
        public virtual Filiacao Filiacao { get; set; }
    }
}
