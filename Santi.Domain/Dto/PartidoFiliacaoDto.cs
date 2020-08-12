using Santi.Domain.Dto.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Dto
{
    public class PartidoFiliacaoDto : EntityBaseDto
    {
        public PartidoDto Partido { get; set; }
        public FiliacaoDto Filiacao { get; set; }
    }
}
