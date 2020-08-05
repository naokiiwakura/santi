﻿using Santi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Santi.Domain.Interfaces.Service
{
    public interface ICandidatoService
    {
        Task<List<Candidato>> ListarTodos();
    }
}