using Appication.Interface;
using Core_Domain;
using Core_Domain.Interface;
using Interface.Appication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UsuarioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioApp _usuarioApp;
        public UsuariosController(IUsuarioApp usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id.HasValue)
            {
                Usuario usuario = _usuarioApp.BuscaPorId(id.Value);

                if (usuario == null)
                    return NotFound();

                return Ok(usuario);
            }
            else
                return Ok(_usuarioApp.Lista());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            return Ok(_usuarioApp.Cadastro(usuario));
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody] Usuario usuario)
        {
            return Ok(_usuarioApp.Atualizacao(id, usuario));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_usuarioApp.Exclui(id));
        }
    }
}
