using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;

namespace Santi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidoController : ControllerBase
    {

        public IActionResult Get()
        {
            var lista = new List<string>();
            lista.Add("PT");
            lista.Add("PSDB");
            return Ok(lista);
        }
    }
}
