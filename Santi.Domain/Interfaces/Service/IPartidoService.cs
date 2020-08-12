using Santi.Domain.Dto;
using Santi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Santi.Domain.Interfaces.Service
{
    public interface IPartidoService
    {
        Task<List<PartidoDto>> ListarTodos();
        Task<PartidoDto> BuscarPorId(int id);
        Task<PartidoDto> Cadastrar(PartidoDto dto);
        Task<PartidoDto> Editar(int id, PartidoDto dto);
        Task<bool> Excluir(int id);
    }
}
