using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Santi.Domain.Interfaces.Service;

namespace Santi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginPartidoController : ControllerBase
    {
        private ILoginService _service;
        public LoginPartidoController(ILoginService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string login, string senha)
        {
            return Ok(await _service.AutenticarPartido(login, senha));
        }
    }
}
