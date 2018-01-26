using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts.Mapeador;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Services.Impl.Mappers
{
    public class LojaMapperProfile : Profile, IPerfilMapeador
    {
        public LojaMapperProfile()
        {
            //CreateMap<Loja, UsuarioOutputDto>();
        }

    }
}
