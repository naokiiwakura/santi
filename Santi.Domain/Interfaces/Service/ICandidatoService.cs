using Santi.Domain.Dto;
using Santi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Santi.Domain.Interfaces.Service
{
    public interface ICandidatoService
    {
        Task<List<CandidatoDto>> ListarTodos();
        Task<CandidatoDto> BuscarPorId(int id);
        Task<CandidatoDto> Cadastrar(CandidatoDto dto);
        Task<CandidatoDto> Editar(int id, CandidatoDto dto);
        Task<bool> Excluir(int id);
    }
}
