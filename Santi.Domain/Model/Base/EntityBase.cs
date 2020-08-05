using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Model.Base
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int UsuarioAlteracao { get; set; }
    }
}
