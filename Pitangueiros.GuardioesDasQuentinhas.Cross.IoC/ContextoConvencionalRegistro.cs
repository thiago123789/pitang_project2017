using System.Reflection;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts{
    public class ContextoConvencionalRegistro : IContextoConvencionalRegistracao
    {
        public Assembly Assembly { get; }
        public IGerenciadorIoC GerenciadorIoC { get; }
        public ConfiguracaoConvencionalRegistro Config { get; }

        internal ContextoConvencionalRegistro(Assembly assembly, IGerenciadorIoC gerenciadorIoC, ConfiguracaoConvencionalRegistro config)
        {
            Assembly = assembly;
            GerenciadorIoC = gerenciadorIoC;
            Config = config;
        }

    }
}