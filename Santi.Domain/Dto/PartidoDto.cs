using Santi.Domain.Dto.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Dto
{
    public class PartidoDto : EntityBaseDto
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public byte[] Foto { get; set; }
        public List<PartidoFiliacaoDto> Filiacoes { get; set; }
        public List<CandidatoDto> Candidatos { get; set; }

    }
}
