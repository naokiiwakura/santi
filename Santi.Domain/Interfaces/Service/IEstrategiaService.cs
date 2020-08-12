using Santi.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Santi.Domain.Interfaces.Service
{
    public interface IEstrategiaService
    {
        Task<List<EstrategiaDto>> ListartTodos();
        Task<EstrategiaDto> BuscarPorId(int id);
        Task<EstrategiaDto> Cadastrar(EstrategiaDto dto);
        Task<EstrategiaDto> Editar(int id, EstrategiaDto dto);
        Task<bool> Excluir(int id);
    }
}
