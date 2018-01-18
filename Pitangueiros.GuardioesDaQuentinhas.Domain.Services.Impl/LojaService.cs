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
        private readonly ILojaRepository lojaRepository;
        private readonly IPedidoRepository pedidoRepository;

        public LojaService(IPratoRepository pratoRepository, IPorcaoRepository porcaoRepository, ILojaRepository lojaRepository, IPedidoRepository pedidoRepository)
        {
            this.pratoRepository = pratoRepository;
            this.porcaoRepository = porcaoRepository;
            this.lojaRepository = lojaRepository;
            this.pedidoRepository = pedidoRepository;
        }

        public void AtualizarStatusDoPedido(long idPedido, StatusPedido status)
        {
            Pedido pedido = pedidoRepository.GetOne(idPedido);
            pedido.StatusPedido = status;
            pedidoRepository.Save(pedido);

        }

        public void CriarNovaPorcao(int idLoja, Porcao porcao)
        {
            Loja loja = lojaRepository.GetOne(idLoja);
            if (porcao != null) this.porcaoRepository.Save(porcao);
            loja.Porcoes.Add(porcao);
            lojaRepository.Save(loja);
        }

        public void CriarNovoPrato(Prato prato, int lojaId)
        {
            Loja loja = this.lojaRepository.GetOne(lojaId);
            if (prato != null) this.pratoRepository.Save(prato);
            loja.Pratos.Add(prato);
            lojaRepository.Save(loja);
        }

        public void AdicionarBairroDeEntrega(string nomeLoja, string bairro) {
            if (nomeLoja != null || bairro != null)
            {
                lojaRepository.ObterPorNome(nomeLoja);
                lojaRepository.ObterPorNome(nomeLoja).BairrosDeEntrega.Add(bairro);

            }
        }

        public void ExcluirBairroDeEntrega(string nomeLoja, string bairro)
        {
            lojaRepository.ObterPorNome(nomeLoja).BairrosDeEntrega.Remove(bairro);
        }

        public void ExcluirPratoDaLoja(int id) {
            pratoRepository.Delete(id);
        }
    }
}
