﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface IVendedorService {
        void CadastrarLoja(Loja loja);
        void RemoverLoja(Loja loja);
    }
}
