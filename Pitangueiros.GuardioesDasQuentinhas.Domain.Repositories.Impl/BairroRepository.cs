﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using System.Data.Entity;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class BairroRepository : EFRepository<Bairro, int>, IBairroRepository
    {
        public BairroRepository(DbContext context) : base(context)
        {

        }
    }
}
