using Santi.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Santi.Domain.Interfaces.Service
{
    public interface IColinhaService
    {
        Task<List<ColinhaDto>> ListartTodos();
        Task<ColinhaDto> BuscarPorId(int id);
        Task<ColinhaDto> Cadastrar(ColinhaDto dto);
        Task<ColinhaDto> Editar(int id, ColinhaDto dto);
        Task<bool> Excluir(int id);
    }
}
