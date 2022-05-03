using System;
using Microsoft.AspNetCore.Mvc;

namespace UsuarioAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return $"Hello World from inside a lambda {DateTime.Now}";
        }
    }
}
