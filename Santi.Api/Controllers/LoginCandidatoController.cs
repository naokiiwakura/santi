using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Santi.Domain.Interfaces.Service;

namespace Santi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginCandidatoController : ControllerBase
    {
        private ILoginService _service;

        public LoginCandidatoController(ILoginService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post(string login, string senha)
        {
            return Ok(await _service.AutenticarCandidato(login, senha));
        }
        
    }
}
