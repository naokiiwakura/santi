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
    public class PartidoService : IPartidoService
    {
        private readonly SantiContext _context;
        public PartidoService(SantiContext context)
        {
            _context = context;
        }

        public async Task<List<Partido>> ListarTodos()
        {
            return await _context.Partido.ToListAsync();
        }
    }
}
