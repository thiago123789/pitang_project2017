﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface ILojaService { 
        void CriarNovoPrato(Prato prato);
        void CriarNovaPorcao(Porcao porcao);
        void ExcluirPratoDaLoja(int id);
        //Precisa ser revisado (Será CEP ou Coordenada ?) \/
        void DefinirAreaDeEntrega(Loja loja, List<string> cep);
        void AtualizarStatusDoPedido(Pedido pedido, StatusPedido status);
    }
}
