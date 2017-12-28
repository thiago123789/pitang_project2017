﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository: IRepository<Usuario, long>
    {
        Usuario ObterPorLogin(string email);
    }
}
