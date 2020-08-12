using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Santi.Api.ViewModel;
using Santi.Domain.Dto;
using Santi.Domain.Interfaces.Service;

namespace Santi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstrategiaController : ControllerBase
    {
        private readonly IEstrategiaService _service;
        private readonly IMapper _mapper;

        public EstrategiaController(IEstrategiaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.ListartTodos());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.BuscarPorId(id));
        }


        // POST api/<Santinho1Controller>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EstrategiaViewModel value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = _mapper.Map<EstrategiaDto>(value);
            return Ok(await _service.Cadastrar(dto));
        }

        // PUT api/<Santinho1Controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] EstrategiaViewModel value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = _mapper.Map<EstrategiaDto>(value);
            return Ok(await _service.Editar(id, dto));
        }

        // DELETE api/<Santinho1Controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var excluido = await _service.Excluir(id);

            if (!excluido)
                return BadRequest("Ocorreu um erro ao tentar excluir uma estrategia");

            return Ok("Excluído com sucesso!");
        }
    }
}
