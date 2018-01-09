using Pitangueiros.GuardioesDasQuentinhas.Cross.Core.Configuracao;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts
{
    public class ConfiguracaoConvencionalRegistro : DicionarioBaseDeConfiguracao{

        public bool InstalarInstaladores { get; set; }

        public ConfiguracaoConvencionalRegistro()
        {
            InstalarInstaladores = true;
        }

    }
}