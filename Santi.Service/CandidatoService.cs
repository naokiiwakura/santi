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
    public class CandidatoService : ICandidatoService
    {


        private SantiContext _context;
        private readonly IMapper _mapper;

        public CandidatoService(SantiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CandidatoDto> BuscarPorId(int id)
        {
            var candidato = _mapper.Map<CandidatoDto>(await _context.Candidato.FirstOrDefaultAsync());

            if (candidato == null)
                return null;

            return candidato;
        }

        public async Task<CandidatoDto> Cadastrar(CandidatoDto dto)
        {
            var candidato = _mapper.Map<Candidato>(dto);

            _context.Candidato.Add(candidato);

            await _context.SaveChangesAsync();

            return _mapper.Map<CandidatoDto>(candidato);
        }

        public async Task<CandidatoDto> Editar(int id, CandidatoDto dto)
        {
            var candidato = await _context.Candidato.FindAsync(id);
            candidato = _mapper.Map(dto, candidato);
            await _context.SaveChangesAsync();
            return _mapper.Map<CandidatoDto>(candidato);
        }

        public async Task<bool> Excluir(int id)
        {
            try
            {
                var candidato = await _context.Candidato.FindAsync(id);
                _context.Remove(candidato);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<CandidatoDto>> ListarTodos()
        {
            return _mapper.Map<List<CandidatoDto>>(await _context.Candidato.ToListAsync());
        }

    }
}
