using Santi.Domain.Dto;
using Santi.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Santi.Domain.Interfaces.Service;

namespace Santi.Service
{
    public class ColinhaService : IColinhaService
    {

        private SantiContext _context;
        public ColinhaService(SantiContext context)
        {
            _context = context;
        }

        public Task<ColinhaDto> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ColinhaDto>> ListartTodos()
        {
            throw new NotImplementedException();
        }
    }
}
