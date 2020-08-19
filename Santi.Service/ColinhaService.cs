using Santi.Domain.Dto;
using Santi.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Santi.Domain.Interfaces.Service;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Santi.Domain.Model;

namespace Santi.Service
{
    public class ColinhaService : IColinhaService
    {

        private readonly SantiContext _context;
        private readonly IMapper _mapper;
        public ColinhaService(SantiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ColinhaDto>> ListartTodos()
        {
            return _mapper.Map<List<ColinhaDto>>(await _context.Colinha.Include(p => p.Candidato).ToListAsync());
        }

        public async Task<ColinhaDto> BuscarPorId(int id)
        {
            var colinha = _mapper.Map<ColinhaDto>(await _context.Colinha.FindAsync(id));

            if (colinha == null)
                return null;

            return colinha;
        }

        public async Task<ColinhaDto> Cadastrar(ColinhaDto dto)
        {
            var colinha = _mapper.Map<Colinha>(dto);

            _context.Colinha.Add(colinha);

            await _context.SaveChangesAsync();

            return _mapper.Map<ColinhaDto>(colinha);
        }

        public async Task<ColinhaDto> Editar(int id, ColinhaDto dto)
        {
            var colinha = await _context.Colinha.FindAsync(id);
            colinha = _mapper.Map(dto, colinha);
            await _context.SaveChangesAsync();
            return _mapper.Map<ColinhaDto>(colinha);
        }

        public async Task<bool> Excluir(int id)
        {
            try
            {
                var colinha = await _context.Colinha.FindAsync(id);
                _context.Remove(colinha);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
