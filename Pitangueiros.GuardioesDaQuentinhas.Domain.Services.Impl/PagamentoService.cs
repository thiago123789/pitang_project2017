﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    public class PagamentoService : IPagamentoService
    {
        public void EscolherOpcaoDePagamento(Pagamento pagamento, OpcaoDePagamento opcaoDePagamento)
        {
            if (pagamento != null) pagamento.OpcaoDePagamento = opcaoDePagamento;
        }
    }
}
