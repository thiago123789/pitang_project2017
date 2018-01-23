using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Contracts
{
    public interface IVendedorAppService : IAppService
    {
        void CadastrarLoja(LojaInputDto loja);
        void DesativarLoja(DesativarLojaInputDto nomeLoja);
    }
}
