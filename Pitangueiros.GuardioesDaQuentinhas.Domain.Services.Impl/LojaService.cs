﻿using System;
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

        public void AtualizarLoja(int idLoja, string nome, string endereco, IList<string> bairros)
        {
            Loja loja = this.lojaRepository.Find(idLoja);
            if (nome != null)
            {
                loja.Nome = nome;
            }
            if (endereco != null)
            {
                loja.EnderecoDaLoja = endereco;
            }
            if (nome != null)
            {
                loja.BairrosDeEntrega = bairros;
            }
            this.lojaRepository.Save();
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

        //public void AdicionarBairroDeEntrega(string nomeLoja, string bairro) {
        //    if (nomeLoja != null || bairro != null)
        //    {
        //        //lojaRepository.ObterPorNome(nomeLoja);
        //        //lojaRepository.ObterPorNome(nomeLoja).BairrosDeEntrega.Add(bairro);
        //
        //    }
        //}

        //public void ExcluirBairroDeEntrega(string nomeLoja, string bairro)
        //{
            //lojaRepository.ObterPorNome(nomeLoja).BairrosDeEntrega.Remove(bairro);
        //}

        public void ExcluirPratoDaLoja(int idPrato) {
            Prato prato = this.pratoRepository.Find(idPrato);
            this.pratoRepository.Desativar(prato);
            this.pratoRepository.Save();
        }
    }
}
