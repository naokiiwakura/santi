using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Santi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidoController : ControllerBase
    {

        public IActionResult Get()
        {
            return ["PT", "PSDB", "PSOL", "NOVO"];
        }
    }
}
