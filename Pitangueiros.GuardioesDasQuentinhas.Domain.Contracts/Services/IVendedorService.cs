using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface IVendedorService {
        void CadastrarLoja(Loja loja);
        void DesativarLoja(string nomeLoja);
        //void CadastrarAreaEntrega(IList CEPs);
    }
}
