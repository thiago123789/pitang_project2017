using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities
{
    public enum StatusPedido
    {
        Recebido = 1,
        Aceito,
        Recusado,
        EmPreparacao,
        SaiuParaEntrega,
        Entregue,
        Cancelado
    }
}