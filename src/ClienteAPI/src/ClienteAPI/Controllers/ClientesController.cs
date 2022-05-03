using Appication.Interface;
using Core_Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClienteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteApp _clienteApp;
        public ClientesController(IClienteApp clienteApp)
        {
            _clienteApp = clienteApp;
        }

        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id.HasValue)
            {
                Cliente cliente = _clienteApp.BuscaPorId(id.Value);

                if (cliente == null)
                    return NotFound();

                return Ok(cliente);
            }
            else
                return Ok(_clienteApp.Lista());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            return Ok(_clienteApp.Cadastro(cliente));
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody] Cliente cliente)
        {
            return Ok(_clienteApp.Atualizacao(id, cliente));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_clienteApp.Exclui(id));
        }
    }
}
