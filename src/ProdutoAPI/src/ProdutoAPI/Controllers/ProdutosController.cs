using Appication.Interface;
using Core_Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProdutoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoApp _produtoApp;
        public ProdutosController(IProdutoApp produtoApp)
        {
            _produtoApp = produtoApp;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id.HasValue)
            {
                Produto produto = _produtoApp.BuscaPorId(id.Value);

                if (produto == null)
                    return NotFound();

                return Ok(produto);
            }
            else
                return Ok(_produtoApp.Lista());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            return Ok(_produtoApp.Cadastro(produto));
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody] Produto produto)
        {
            return Ok(_produtoApp.Atualizacao(id, produto));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_produtoApp.Exclui(id));
        }
    }
}
