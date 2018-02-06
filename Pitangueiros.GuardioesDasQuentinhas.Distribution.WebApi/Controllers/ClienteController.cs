using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteAppService clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            this.clienteAppService = clienteAppService;
        }

        [HttpPost]
        public void FazerPedido(PedidoInputDto pedido)
        {
            this.clienteAppService.FazerPedido(pedido);
        }

        [HttpPost]
        public void CriarPratoEmPedido(PratoClienteInputDto pratoCliente)
        {
            this.clienteAppService.CriarPratoEmPedido(pratoCliente);
        }

        [HttpPost]
        public void InserirPratoNoPedido(InserirPratoInputDto inserirPrato)
        {
            this.clienteAppService.InserirPratoNoPedido(inserirPrato);
        }

        [HttpPost]
        public void AdicionarUmCartao(CartaoInputDto cartao)
        {
            this.clienteAppService.AdicionarUmCartao(cartao);
        }

        [HttpPost]
        public void RealizarPagamento(PagamentoInputDto pagamento)
        {
            this.clienteAppService.RealizarPagamento(pagamento);
        }

        [HttpPost]
        public void AvaliarPedido(AvaliacaoInputDto avaliacao)
        {
            this.clienteAppService.AvaliarPedido(avaliacao);
        }

        [HttpPut]
        public void CancelarPedido(long idPedido)
        {
            this.clienteAppService.CancelarPedido(idPedido);
        }

        [HttpPut]
        public void DesativarCartao(int idCartao)
        {
            this.clienteAppService.DesativarCartao(idCartao);
        }

        [HttpPut]
        public void AtualizarCartao(AtualizarCartaoInputDto atualizarCartao)
        {
            this.clienteAppService.AtualizarCartao(atualizarCartao);
        }

        [HttpGet]
        public ListarLojasOutputDto ListarLojas()
        {
            IList<Loja> lojas = this.clienteAppService.ListarLojas();

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
            IList<Porcao> porcoes = this.clienteAppService.ListarPorcoesDaLoja(idLoja);

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
            IList<Porcao> porcoes = this.clienteAppService.ListarPorcoesPrato(idPrato);

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
            IList<Prato> pratos = this.clienteAppService.ListarPratosDaLoja(idLoja);

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
            IList<Bairro> bairros = this.clienteAppService.ListarBairrosLoja(idLoja);

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
        public ListarCartoesDoClienteOutputDto ListarCartoesCliente(int idCliente)
        {
            IList<Cartao> cartoes = this.clienteAppService.ListarCartoesCliente(idCliente);

            IList<CartaoOutputDto> cartoesOutput = new List<CartaoOutputDto>();

            foreach (Cartao cartao in cartoes)
            {
                CartaoOutputDto cartaoOutput = new CartaoOutputDto();
                cartaoOutput.Id = cartao.Id;
                cartaoOutput.NomeTitular = cartao.NomeTitular;
                cartaoOutput.Numero = cartao.Numero;
                cartaoOutput.Validade = cartao.Validade;
                cartaoOutput.CodSeg = cartao.CodSeg;
                cartaoOutput.DataCriacao = cartao.DataCriacao;
                cartaoOutput.UltimaModificacao = cartao.UltimaModificacao;
                cartoesOutput.Add(cartaoOutput);
            }
            return new ListarCartoesDoClienteOutputDto
            {
                IdCliente = idCliente,
                Cartoes = cartoesOutput
            };
        }
    }
}