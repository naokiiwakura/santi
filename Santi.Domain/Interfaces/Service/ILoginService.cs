using Santi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Santi.Domain.Interfaces.Service
{
    public interface ILoginService
    {
        Task<Candidato> AutenticarCandidato(string login, string senha);
        Task<Partido> AutenticarPartido(string login, string senha);
    }
}
