using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Pitangueiros.Blog.Cross.Core.Collections.Extensions;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.Core.Configuracao
{
    public class DicionarioBaseDeConfiguracao : IDicionarioBaseDeConfiguracao
    {

        protected Dictionary<string, object> ConfiguracoesPersonalizadas { get; }


        public Object this[string nome]
        {
            get => ConfiguracoesPersonalizadas.GetOrDefault(nome);
            set => ConfiguracoesPersonalizadas[nome] = value;
        }

        public DicionarioBaseDeConfiguracao()
        {
            ConfiguracoesPersonalizadas = new Dictionary<string, object>();
        }

        public void Definir<T>(string nome, T valor)
        {
            this[nome] = valor;
        }

        public object Recuperar(string nome)
        {
            return Recuperar(nome, null);
        }

        public T Recuperar<T>(string nome)
        {
            var valor = this[nome];
            return valor == null ? default(T) : (T) Convert.ChangeType(valor, typeof(T));
        }

        public object Recuperar(string nome, object valorPadrao)
        {
            var valor = this[nome];
            if (valor == null)
            {
                return valorPadrao;
            }

            return this[nome];
        }

        public T Recuperar<T>(string nome, T valorPadrao)
        {
            return (T) Recuperar(nome, (object) valorPadrao);
        }

        public T RecuperarOuCriar<T>(string nome, Func<T> criador)
        {
            var valor = Recuperar(nome);
            if (valor == null)
            {
                valor = criador;
                Definir(nome, valor);
            }

            return (T) valor;
        }
    }
}