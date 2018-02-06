﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface ILojaService : IDependenciaTransient
    { 
        void CriarNovoPrato(int idLoja, IList<long> idPorcoes, Prato prato);
        void CriarNovaPorcao(int idLoja, Porcao porcao);
        void ExcluirPratoDaLoja(int idPrato);
        void ExcluirPorcaoDaLoja(int idPorcao);
        void AdicionarBairroDeEntrega(int idLoja, Bairro bairro);
        void ExcluirBairroDeEntrega(int idBairro);
        void AtualizarStatusDoPedido(long idPedido, StatusPedido status);
        IList<Porcao> ListarPorcoesLoja(int idLoja);
        IList<Pedido> ListarPedidosLoja(int idLoja);
        IList<Loja> ListarTodasLojas();                       
        IList<Prato> ListarPratosLoja(int idLoja);            
        IList<Bairro> ListarBairrosLoja(int idLoja);
        IList<Porcao> ListarPorcoesPrato(int idPrato);
        IList<string> ListarCategoriaPorcao();
    }
}
