using System;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using System.Collections.Generic;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    public class LojaService : ILojaService  {

        private readonly IPratoRepository pratoRepository;

        public LojaService(IPratoRepository pratoRepository)
        {
            this.pratoRepository = pratoRepository;
        }

        public void AtualizarStatusDoPedido(Pedido pedido, StatusPedido status) {
            if (pedido!= null) pedido.StatusPedido = status;
        }

        public void CriarNovoPrato(Prato prato) {
            if (prato != null) this.pratoRepository.Save(prato);
        }

        public void DefinirAreaDeEntrega(Loja loja, List<string> ceps) {
            if (loja != null && ceps != null) loja.Ceps = ceps;
        }

        public void ExcluirPratoDaLoja(Prato prato) {
            if (prato != null) pratoRepository.Delete(prato);
        }
    }
}
