using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.Controllers
{
    public class UsuarioController : ApiController
    {

        private readonly IUsuarioAppService servicoDeUsuario;

        public UsuarioController(IUsuarioAppService servico){
            this.servicoDeUsuario = servico;
        }

        // GET: api/Usuario
        //public IEnumerable<string> Get(long id)
        //{
        //    return null;
        //}

        // POST: api/Usuario
        public UsuarioOutputDto Post(UsuarioInputDto value)
        {
            this.servicoDeUsuario.CriarUsuario(value);
            return new UsuarioOutputDto
            {
                Nome = value.Nome,
                Email = value.Email
            };
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
