using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsuarioController : ApiController
    {

        private readonly IUsuarioAppService usuarioAppService;

        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            this.usuarioAppService = usuarioAppService;
        }

        // GET: api/Usuario
        //public IEnumerable<string> Get(long id)
        //{
        //    return null;
        //}

        // POST: api/Usuario
        [HttpPost]
        public UsuarioOutputDto CriarUsuario(UsuarioInputDto usuario)
        {
            this.usuarioAppService.CriarUsuario(usuario);
            return new UsuarioOutputDto
            {
                Nome = usuario.Nome,
                Email = usuario.Email
            };
        }

        [HttpPut]
        public void DesativarUsuario(int idLoja)
        {
            this.usuarioAppService.DesativarUsuario(idLoja);
        }

        // PUT: api/Usuario/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/Usuario/5
        //public void Delete(int id)
        //{
        //}
    }
}
