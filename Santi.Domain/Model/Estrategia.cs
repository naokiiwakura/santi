using Santi.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Santi.Domain.Model
{
    public class Estrategia : EntityBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}