﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Services.Impl
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }
        public bool Autenticar(AutenticacaoInputDto login)
        {
            return this.usuarioService.Autenticar(login.Login, login.Senha);
        }

        public void CriarUsuario(UsuarioInputDto usuario)
        {
            this.usuarioService.CriarUsuario(new Usuario
            {
                Email = usuario.Email,
                Nome = usuario.Nome,
                Senha = usuario.Senha

            });
        }
  
        public void DesativarUsuario(DesativarUsuarioInputDto login)
        {
            this.usuarioService.DesativarUsuario(login.Login);
        }
    }
}