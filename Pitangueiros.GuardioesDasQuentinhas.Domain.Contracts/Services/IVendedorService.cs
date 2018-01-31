using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface IVendedorService : IDependenciaTransient
    {
        void CadastrarLoja(long idVendedor, Loja loja);
        void DesativarLoja(int idLoja);
        void AtualizarLoja(int idLoja, Loja lojaAtualizada);
        //void CadastrarAreaEntrega(IList CEPs);
    }
}
