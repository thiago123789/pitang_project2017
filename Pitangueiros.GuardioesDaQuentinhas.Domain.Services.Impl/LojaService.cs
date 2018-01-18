using System;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using System.Collections.Generic;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    public class LojaService : ILojaService  {

        private readonly IPratoRepository pratoRepository;
        private readonly IPorcaoRepository porcaoRepository;

        public LojaService(IPratoRepository pratoRepository, IPorcaoRepository porcaoRepository)
        {
            this.pratoRepository = pratoRepository;
            this.porcaoRepository = porcaoRepository;
        }

        public void AtualizarStatusDoPedido(long idPedido, string status) {
            //if (pedido!= null) pedido.StatusPedido = status;
        }

        public void CriarNovaPorcao(Porcao porcao)
        {
            if (porcao != null) this.porcaoRepository.Save(porcao);
        }

        public void CriarNovoPrato(Prato prato) {
            if (prato != null) this.pratoRepository.Save(prato);
        }

        public void DefinirAreaDeEntrega(Loja loja, List<string> ceps) {
            if (loja != null && ceps != null) loja.CEPsDeEntrega = ceps;
        }

        public void ExcluirPratoDaLoja(int id) {
            pratoRepository.Delete(id);
        }
    }
}
