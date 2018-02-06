using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LojaController : ApiController
    {
        private readonly ILojaAppService lojaAppService;
        public LojaController(ILojaAppService lojaAppService)
        {
            this.lojaAppService = lojaAppService;
        }

        [HttpPost]
        public void CriarNovaPorcao(PorcaoInputDto porcao)
        {
            this.lojaAppService.CriarNovaPorcao(porcao);
        }

        [HttpPut]
        public void ExcluirPratoDaLoja(int idPrato)
        {
            this.lojaAppService.ExcluirPratoDaLoja(idPrato);
        }

        [HttpPut]
        public void ExcluirPorcaoDaLoja(int idPorcao)
        {
            this.lojaAppService.ExcluirPorcaoDaLoja(idPorcao);
        }

        [HttpPut]
        public void ExcluirBairroDeEntrega(int idBairro)
        {
            this.lojaAppService.ExcluirBairroDeEntrega(idBairro);
        }

        [HttpPut]
        public void AtualizarStatusDoPedido(AtualizarStatusInputDto atualizarStatus)
        {
            this.lojaAppService.AtualizarStatusDoPedido(atualizarStatus);
        }

        [HttpPost]
        public void CriarNovoPrato(PratoInputDto prato)
        {
            this.lojaAppService.CriarNovoPrato(prato);
        }

        [HttpPost]
        public void AdicionarBairroDeEntrega(BairroInputDto bairro)
        {
            this.lojaAppService.AdicionarBairroDeEntrega(bairro);
        }

        [HttpGet]
        public ListarPorcoesDaLojaOutputDto ListarPorcoesLoja(int idLoja)
        {
            IList<Porcao> porcoes = this.lojaAppService.ListarPorcoesLoja(idLoja);
            IList<PorcaoOutputDto> porcoesOutput = new List<PorcaoOutputDto>();

            foreach (Porcao porcao in porcoes)
            {
                PorcaoOutputDto porcaoOutput = new PorcaoOutputDto();
                porcaoOutput.Item = porcao.Item;
                porcaoOutput.Quantidade = porcao.Quantidade;
                porcaoOutput.Preco = porcao.Preco;
                porcaoOutput.CategoriaPorcao = porcao.CategoriaPorcao;
                porcaoOutput.DataCriacao = porcao.DataCriacao;
                porcaoOutput.UltimaModificacao = porcao.UltimaModificacao;
                porcaoOutput.Id = porcao.Id;
                porcoesOutput.Add(porcaoOutput);
            };

            return new ListarPorcoesDaLojaOutputDto
            {
                IdLoja = idLoja,
                Porcoes = porcoesOutput
            };
        }

        [HttpGet]
        public ListarPedidosDaLojaOutputDto ListarPedidosDaLoja(int idLoja)
        {
            IList<Pedido> listaPedidos = this.lojaAppService.ListarPedidosLoja(idLoja);
            IList<PedidoOutputDto> pedidosOutput = new List<PedidoOutputDto>();

            foreach (Pedido pedido in listaPedidos)
            {
                PedidoOutputDto pedidoOutput = new PedidoOutputDto();
                pedidoOutput.Id = pedido.Id;
                pedidoOutput.StatusPedido = pedido.StatusPedido;
                //pedidoOutput.Avaliacao = new AvaliacaoOutputDto();
                pedidoOutput.Comentario = pedido.Comentario;
                pedidoOutput.DataCriacao = pedido.DataCriacao;
                //pedidoOutput.Pagamento = new PagamentoOutputDto();
                pedidoOutput.Preco = pedido.Preco;
                pedidoOutput.UltimaModificacao = pedido.UltimaModificacao;
                pedidosOutput.Add(pedidoOutput);
            };

            return new ListarPedidosDaLojaOutputDto
            {
                IdLoja = idLoja,
                Pedidos = pedidosOutput
            };
        }

        [HttpGet]
        public ListarLojasOutputDto ListarLojas()
        {
            IList<Loja> lojas = this.lojaAppService.ListarLojas();

            IList<LojaOutputDto> lojasOutput = new List<LojaOutputDto>();

            foreach (Loja loja in lojas)
            {
                LojaOutputDto lojaOutput = new LojaOutputDto();
                lojaOutput.Id = loja.Id;
                lojaOutput.Nome = loja.Nome;
                lojaOutput.EnderecoDaLoja = loja.EnderecoDaLoja;
                lojaOutput.MediaAvaliacoes = loja.MediaAvaliacoes;
                lojaOutput.DataCriacao = loja.DataCriacao;
                lojaOutput.UltimaModificacao = loja.UltimaModificacao;
                lojasOutput.Add(lojaOutput);

            }

            return new ListarLojasOutputDto
            {
                Lojas = lojasOutput
            };
        }

        [HttpGet]
        public ListarPorcoesDaLojaOutputDto ListarPorcoesDaLoja(int idLoja)
        {
            IList<Porcao> porcoes = this.lojaAppService.ListarPorcoesLoja(idLoja);

            IList<PorcaoOutputDto> porcoesOutput = new List<PorcaoOutputDto>();

            foreach (Porcao porcao in porcoes)
            {
                PorcaoOutputDto porcaoOutput = new PorcaoOutputDto();
                porcaoOutput.Item = porcao.Item;
                porcaoOutput.Quantidade = porcao.Quantidade;
                porcaoOutput.Preco = porcao.Preco;
                porcaoOutput.CategoriaPorcao = porcao.CategoriaPorcao;
                porcaoOutput.DataCriacao = porcao.DataCriacao;
                porcaoOutput.UltimaModificacao = porcao.UltimaModificacao;
                porcaoOutput.Id = porcao.Id;
                porcoesOutput.Add(porcaoOutput);
            };

            return new ListarPorcoesDaLojaOutputDto
            {
                IdLoja = idLoja,
                Porcoes = porcoesOutput
            };
        }

        [HttpGet]
        public ListarPorcoesDoPratoOutputDto ListarPorcoesPrato(int idPrato)
        {
            IList<Porcao> porcoes = this.lojaAppService.ListarPorcoesPrato(idPrato);

            IList<PorcaoOutputDto> porcoesOutput = new List<PorcaoOutputDto>();

            foreach (Porcao porcao in porcoes)
            {
                PorcaoOutputDto porcaoOutput = new PorcaoOutputDto();
                porcaoOutput.Item = porcao.Item;
                porcaoOutput.Quantidade = porcao.Quantidade;
                porcaoOutput.Preco = porcao.Preco;
                porcaoOutput.CategoriaPorcao = porcao.CategoriaPorcao;
                porcaoOutput.DataCriacao = porcao.DataCriacao;
                porcaoOutput.UltimaModificacao = porcao.UltimaModificacao;
                porcaoOutput.Id = porcao.Id;
                porcoesOutput.Add(porcaoOutput);
            };

            return new ListarPorcoesDoPratoOutputDto
            {
                IdPrato = idPrato,
                Porcoes = porcoesOutput
            };
        }

        [HttpGet]
        public ListarPratosDaLojaOutputDto ListarPratosDaLoja(int idLoja)
        {
            IList<Prato> pratos = this.lojaAppService.ListarPratosDaLoja(idLoja);

            IList<PratoOutputDto> pratosOutput = new List<PratoOutputDto>();

            foreach (Prato prato in pratos)
            {
                PratoOutputDto pratoOutput = new PratoOutputDto();
                pratoOutput.Id = prato.Id;
                pratoOutput.Preco = prato.Preco;
                pratoOutput.DataCriacao = prato.DataCriacao;
                pratoOutput.UltimaModificacao = prato.UltimaModificacao;
                pratosOutput.Add(pratoOutput);
            }
            return new ListarPratosDaLojaOutputDto
            {
                IdLoja = idLoja,
                Pratos = pratosOutput
            };
        }

        [HttpGet]
        public ListarBairrosDaLojaOutputDto ListarBairrosDaLoja(int idLoja)
        {
            IList<Bairro> bairros = this.lojaAppService.ListarBairrosLoja(idLoja);

            IList<BairroOutputDto> bairrosOutput = new List<BairroOutputDto>();

            foreach (Bairro bairro in bairros)
            {
                BairroOutputDto bairroOutput = new BairroOutputDto();
                bairroOutput.Id = bairro.Id;
                bairroOutput.Nome = bairro.Nome;
                bairroOutput.DataCriacao = bairro.DataCriacao;
                bairroOutput.UltimaModificacao = bairro.UltimaModificacao;
                bairrosOutput.Add(bairroOutput);
            }
            return new ListarBairrosDaLojaOutputDto
            {
                IdLoja = idLoja,
                Bairros = bairrosOutput
            };
        }

        [HttpGet]
        public IList<string> ListarCategoriaPorcao()
        {
            IList<string> categoriaPorcao = this.lojaAppService.ListarCategoriaPorcao();
            return categoriaPorcao;
        }
    }
}