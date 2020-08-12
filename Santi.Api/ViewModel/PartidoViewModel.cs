using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Santi.Api.ViewModel
{
    public class PartidoViewModel
    {
        [Required(ErrorMessage = "Nome é Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sigla é Obrigatório")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "Login é Obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha é Obrigatório")]
        public string Senha { get; set; }
        public IFormFile Foto { get; set; }
    }
}