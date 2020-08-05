using Microsoft.EntityFrameworkCore;
using Santi.Domain.Interfaces.Service;
using Santi.Domain.Model;
using Santi.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santi.Service
{
    public class LoginService : ILoginService
    {
        private SantiContext _context;

        public LoginService(SantiContext context)
        {
            _context = context;
        }
        public async Task<Candidato> AutenticarCandidato(string login, string senha)
        {
            var candidato = await _context.Candidato
                .Where(p => p.Login == login && p.Senha == senha)
                .FirstOrDefaultAsync();

            return candidato;
        }

        public async Task<Partido> AutenticarPartido(string login, string senha)
        {
            var partido = await _context.Partido
                .Where(p => p.Login == login && p.Senha == senha)
                .FirstOrDefaultAsync();

            return partido;
        }
    }
}
