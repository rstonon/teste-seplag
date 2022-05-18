using API.Entities;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("api/pessoas")]
    public class PessoasController : Controller
    {
        // GET api/pessoas
        [HttpGet]
        public IActionResult GetAll()
        {
            var pessoas = new List<Pessoa>();

            return Ok(pessoas);
        }

        // GET api/packages/123
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST api/pessoas
        [HttpPost]
        public IActionResult Post(AddPessoaInputModel model)
        {
            return Ok();
        }

        // PUT api/packages/123
        [HttpPut("{id}")]
        public IActionResult Put(UpdatePessoaInputModel model)
        {
            return NoContent();
        }
    }
}
