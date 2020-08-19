using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Santi.Domain.Dto;
using Santi.Domain.Interfaces.Service;
using Santi.Domain.Model;
using Santi.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Santi.Service
{    
    public class PartidoService : IPartidoService
    {
        private readonly SantiContext _context;
        private readonly IMapper _mapper;
        public PartidoService(SantiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PartidoDto> BuscarPorId(int id)
        {
            var partido = _mapper.Map<PartidoDto>(await _context.Partido.FindAsync(id));

            if (partido == null)
                return null;

            return partido;
        }

        public async Task<PartidoDto> Cadastrar(PartidoDto dto)
        {
            var partido = _mapper.Map<Partido>(dto);

            _context.Partido.Add(partido);

            await _context.SaveChangesAsync();

            return _mapper.Map<PartidoDto>(partido);
        }

        public async Task<PartidoDto> Editar(int id, PartidoDto dto)
        {
            var partido = await _context.Partido.FindAsync(id);
            partido = _mapper.Map(dto, partido);
            await _context.SaveChangesAsync();
            return _mapper.Map<PartidoDto>(partido);
        }

        public async Task<bool> Excluir(int id)
        {
            try
            {
                var partido = await _context.Partido.FindAsync(id);
                _context.Remove(partido);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<PartidoDto>> ListarTodos()
        {
            return _mapper.Map<List<PartidoDto>>(await _context.Partido.ToListAsync());
        }
    }
}