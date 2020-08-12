using Santi.Domain.Dto.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Dto
{
    public class FiliacaoDto : EntityBaseDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<PartidoFiliacaoDto> Partidos { get; set; }
    }
}
