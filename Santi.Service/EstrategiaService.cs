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
    public class EstrategiaService : IEstrategiaService
    {
        private readonly SantiContext _context;
        private readonly IMapper _mapper;
        public EstrategiaService(SantiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EstrategiaDto> BuscarPorId(int id)
        {
            var estrategia = _mapper.Map<EstrategiaDto>(await _context.Estrategia.FindAsync(id));

            if (estrategia == null)
                return null;

            return estrategia;
        }

        public async Task<EstrategiaDto> Cadastrar(EstrategiaDto dto)
        {
            var estrategia = _mapper.Map<Estrategia>(dto);

            _context.Estrategia.Add(estrategia);

            await _context.SaveChangesAsync();

            return _mapper.Map<EstrategiaDto>(estrategia);
        }

        public async Task<EstrategiaDto> Editar(int id, EstrategiaDto dto)
        {
            var estrategia = await _context.Estrategia.FindAsync(id);
            estrategia = _mapper.Map(dto, estrategia);
            await _context.SaveChangesAsync();
            return _mapper.Map<EstrategiaDto>(estrategia);
        }

        public async Task<bool> Excluir(int id)
        {
            try
            {
                var estrategia = await _context.Estrategia.FindAsync(id);
                _context.Remove(estrategia);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<EstrategiaDto>> ListartTodos()
        {
            return _mapper.Map<List<EstrategiaDto>>(await _context.Estrategia.ToListAsync());
        }
    }
}