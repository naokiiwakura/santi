using Santi.Domain.Dto.BaseDto;
using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace Santi.Domain.Dto
{
    public class SantinhoDto : EntityBaseDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Foto { get; set; }
        public int CandidatoId { get; set; }
        public virtual CandidatoDto Candidato { get; set; }
    }
}