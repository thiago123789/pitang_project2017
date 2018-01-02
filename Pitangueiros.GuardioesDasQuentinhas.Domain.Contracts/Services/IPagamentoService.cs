using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface IPagamentoService
    {
        void EscolherOpcaoDePagamento(Pagamento pagamento, OpcaoDePagamento opcaoDePagamento);
    }
}
