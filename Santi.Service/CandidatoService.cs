using Microsoft.EntityFrameworkCore;
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

        public CandidatoService(SantiContext context)
        {
            _context = context;
        }

        public async Task<List<Candidato>> ListarTodos()
        {
            return await _context.Candidato.ToListAsync();
        }
    }
}
