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
    public class CandidatoController : ControllerBase
    {

        private ICandidatoService _service;
        public CandidatoController(ICandidatoService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Get()
        {
            return Ok(await _service.ListarTodos());
        }
    }
}
