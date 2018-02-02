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
        private readonly IBairroRepository bairroRepository;

        public LojaService(IPratoRepository pratoRepository, IPorcaoRepository porcaoRepository, ILojaRepository lojaRepository, IPedidoRepository pedidoRepository, IBairroRepository bairroRepository)
        {
            this.pratoRepository = pratoRepository;
            this.porcaoRepository = porcaoRepository;
            this.lojaRepository = lojaRepository;
            this.pedidoRepository = pedidoRepository;
            this.bairroRepository = bairroRepository;
        }


        public void AtualizarStatusDoPedido(long idPedido, StatusPedido statusPedido)
        {
            Pedido pedido = this.pedidoRepository.Find(idPedido);
            pedido.StatusPedido = statusPedido;
            this.pedidoRepository.Save();

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

        public void AdicionarBairroDeEntrega(int idLoja, Bairro bairro)
        {
            if (bairro != null)
            {
                Loja loja = this.lojaRepository.Find(idLoja);
                bairro.Loja = loja;
                loja.Bairros.Add(bairro);
                this.lojaRepository.Save();

            }
        }

        public void ExcluirBairroDeEntrega(int idBairro)
        {
            Bairro bairro = this.bairroRepository.Find(idBairro);
            this.bairroRepository.Desativar(bairro);
            this.bairroRepository.Save();
        }

        public void ExcluirPratoDaLoja(int idPrato) {
            Prato prato = this.pratoRepository.Find(idPrato);
            this.pratoRepository.Desativar(prato);
            this.pratoRepository.Save();
        }

        public void ExcluirPorcaoDaLoja(int idPorcao)
        {
            Porcao porcao = this.porcaoRepository.Find(idPorcao);
            this.porcaoRepository.Desativar(porcao);
            this.porcaoRepository.Save();
        }
    }
}
