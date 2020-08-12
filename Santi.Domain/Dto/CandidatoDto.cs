using Santi.Domain.Dto.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Dto
{
    public class CandidatoDto : EntityBaseDto
    {
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public int Numero { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public byte[] Foto { get; set; }
        public int PartidoId { get; set; }
        public  PartidoDto Partido { get; set; }
        public  List<ColinhaDto> Colinhas { get; set; }
        public  List<SantinhoDto> Santinhos { get; set; }
    }
}
