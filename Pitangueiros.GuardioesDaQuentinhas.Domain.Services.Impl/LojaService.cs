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
            pedidoRepository.Add(pedido);

        }

        public void CriarNovaPorcao(int idLoja, Porcao porcao)
        {
            if (porcao != null)
            {
                Loja loja = lojaRepository.Find(idLoja);
                porcao.Loja = loja;
                loja.Porcoes.Add(porcao);
                this.lojaRepository.Save();
            }
        }

        public void CriarNovoPrato(int idLoja, IList<long> idPorcoes, Prato prato)
        {
            if (prato != null)
            {
                Loja loja = this.lojaRepository.Find(idLoja);
                prato.Loja = loja;
                loja.Pratos.Add(prato);
                this.lojaRepository.Save();
                IList<Porcao> porcoes = this.porcaoRepository.FindList(idPorcoes);
                prato.Porcoes = porcoes;
                this.porcaoRepository.Save();
            }
        }

        public void AdicionarBairroDeEntrega(int idLoja, string bairro)
        {
            if (bairro != null)
            {
                Loja loja = lojaRepository.Find(idLoja);
                if (!loja.BairrosDeEntrega.Contains(bairro))
                {
                    loja.BairrosDeEntrega.Add(bairro);
                    lojaRepository.Save();
                }
            }
        }

        public void ExcluirBairroDeEntrega(int idLoja, string bairro)
        {
            if (bairro != null)
            {
                Loja loja = lojaRepository.Find(idLoja);
                if (loja.BairrosDeEntrega.Contains(bairro))
                {
                    lojaRepository.Find(idLoja).BairrosDeEntrega.Remove(bairro);
                    lojaRepository.Save();
                }
            }
        }

        public void ExcluirPratoDaLoja(int idPrato) {
            Prato prato = this.pratoRepository.Find(idPrato);
            this.pratoRepository.Desativar(prato);
            this.pratoRepository.Save();
        }
    }
}
