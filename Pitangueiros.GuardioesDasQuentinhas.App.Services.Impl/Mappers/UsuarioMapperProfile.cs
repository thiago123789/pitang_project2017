using AutoMapper;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts.Mapeador;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Services.Impl.Mappers
{
    public class UsuarioMapperProfile: Profile, IPerfilMapeador
    {
        public UsuarioMapperProfile()
        {
            CreateMap<Usuario, UsuarioOutputDto>();
        }
    }
}
