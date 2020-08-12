using Santi.Domain.Dto;
using Santi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Santi.Domain.Interfaces.Service
{
    public interface ISantinhoService
    {
        Task<List<SantinhoDto>> ListartTodos();
        Task<SantinhoDto> BuscarPorId(int id);
        Task<SantinhoDto> Cadastrar(SantinhoDto dto);
        Task<SantinhoDto> Editar(int id, SantinhoDto dto);
        Task<bool> Excluir(int id);
    }
}
