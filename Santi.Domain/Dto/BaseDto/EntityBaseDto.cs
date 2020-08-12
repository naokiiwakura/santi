using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Dto.BaseDto
{
    public abstract class EntityBaseDto
    {
        public int Id { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int UsuarioAlteracao { get; set; }
    }
}
