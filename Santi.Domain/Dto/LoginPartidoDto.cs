﻿using Santi.Domain.Dto.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Domain.Dto
{
    public class LoginPartidoDto : EntityBaseDto
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
