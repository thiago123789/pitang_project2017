using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities
{
    public enum StatusPedido
    {
        Iniciado = 1,
        Recebido,
        Aceito,
        Recusado,
        EmPreparacao,
        SaiuParaEntrega,
        Entregue,
        Cancelado
    }
}