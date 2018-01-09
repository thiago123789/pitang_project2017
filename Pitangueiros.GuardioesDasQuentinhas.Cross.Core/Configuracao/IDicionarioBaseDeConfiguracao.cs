using System;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.Core.Configuracao
{
    public interface IDicionarioBaseDeConfiguracao
    {
        void Definir<T>(string nome, T valor);

        object Recuperar(String nome);

        T Recuperar<T>(String nome);

        object Recuperar(String nome, object valorPadrao);

        T Recuperar<T>(String nome, T valorPadrao);

        T RecuperarOuCriar<T>(String nome, Func<T> criador);

    }
}