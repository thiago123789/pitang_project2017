using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Contracts
{
    interface IVendedorAppService : IApplicationService
    {
        void CadastrarLoja(LojaInputDto lojas);
        void DesativarLoja(DesativarLojaInputDto nomeLoja);
    }
}
