using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Santi.Api.ViewModel
{
    public class ColinhaViewModel
    {
        [Required(ErrorMessage ="Nome é Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição é Obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Identificador do Candidato é Obrigatório")]
        public int? CandidatoId { get; set; }
    }
}
