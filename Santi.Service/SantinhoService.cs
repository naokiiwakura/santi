using Microsoft.EntityFrameworkCore;
using Santi.Domain.Dto;
using Santi.Domain.Interfaces.Service;
using Santi.Domain.Model;
using Santi.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;

namespace Santi.Service
{
    public class SantinhoService : ISantinhoService
    {
        private readonly SantiContext _context;
        private readonly IMapper _mapper;

        public SantinhoService(SantiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<SantinhoDto>> ListartTodos()
        {
            return _mapper.Map<List<SantinhoDto>>(await _context.Santinho.Include(p => p.Candidato).ToListAsync());
        }

        public async Task<SantinhoDto> BuscarPorId(int id)
        {
            var santihno = _mapper.Map<SantinhoDto>(await _context.Santinho.Include(p => p.Candidato).FirstOrDefaultAsync());

            if (santihno == null)
                return null;

            return santihno;
        }

        public async Task<SantinhoDto> Cadastrar(SantinhoDto dto)
        {
            var santinho = _mapper.Map<Santinho>(dto);

            _context.Santinho.Add(santinho);

            await _context.SaveChangesAsync();

            return _mapper.Map<SantinhoDto>(santinho);
        }

        public async Task<SantinhoDto> Editar(int id, SantinhoDto dto)
        {
            var santinho = await _context.Santinho.FindAsync(id);
            santinho = _mapper.Map(dto, santinho);
            await _context.SaveChangesAsync();
            return _mapper.Map<SantinhoDto>(santinho);
        }

        public async Task<bool> Excluir(int id)
        {
            try
            {
                var santinho = await _context.Santinho.FindAsync(id);
                _context.Remove(santinho);
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
