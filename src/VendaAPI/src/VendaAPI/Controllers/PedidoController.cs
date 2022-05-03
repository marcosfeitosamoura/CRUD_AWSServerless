using Appication.Interface;
using Core_Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoApp _pedidoApp;
        public PedidoController(IPedidoApp pedidoApp)
        {
            _pedidoApp = pedidoApp;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id.HasValue)
            {
                Pedido pedido = _pedidoApp.BuscaPorId(id.Value);

                if (pedido == null)
                    return NotFound();

                return Ok(pedido);
            }
            else
                return Ok(_pedidoApp.Lista());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            return Ok(_pedidoApp.Cadastro(pedido));
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody] Pedido pedido)
        {
            return Ok(_pedidoApp.Atualizacao(id, pedido));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_pedidoApp.Exclui(id));
        }
    }
}
