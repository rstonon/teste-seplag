using API.Entities;
using API.Models;
using API.Persistence;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/pessoas")]
    public class PessoasController : Controller
    {
        private readonly PessoaContext _context;
        public PessoasController(PessoaContext context)
        {
            _context = context;
        }

        // GET api/pessoas
        [HttpGet]
        public IActionResult GetAll()
        {
            var pessoas = _context.Pessoas;

            return Ok(pessoas);
        }

        // GET api/packages/123
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var pessoa = _context.Pessoas.SingleOrDefault(p => p.Id == id);

            if (pessoa == null)
                return NotFound();

            return Ok(pessoa);
        }

        // POST api/pessoas
        [HttpPost]
        public IActionResult Post(AddPessoaInputModel model)
        {
            var pessoa = new Pessoa(
                model.cpf_Cnpj,
                model.razao_Social,
                model.nome_Fantasia,
                model.tipo_empresa,
                model.data_Constituicao,
                model.porte,
                model.telefone,
                model.telefone2,
                model.telefone3,
                model.site,
                model.email,
                model.caracterizacao_Capital,
                model.quantidade_Quota,
                model.valor_Quota,
                model.capital_Social,
                model.estado_Civil,
                model.profissao,
                model.data_Nascimento,
                model.genero,
                model.nacionalidade,
                model.tipo_Pessoa,
                model.nacional
            );

            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();

            return CreatedAtAction("GetById", new {id = pessoa.Id}, pessoa);
        }

        // PUT api/packages/123
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdatePessoaInputModel model)
        {
            var pessoa = _context.Pessoas.SingleOrDefault(p => p.Id == id);

            if (pessoa == null)
                return NotFound();


            pessoa.Update(
                model.cpf_Cnpj,
                model.razao_Social,
                model.nome_Fantasia,
                model.tipo_empresa,
                model.data_Constituicao,
                model.porte,
                model.telefone,
                model.telefone2,
                model.telefone3,
                model.site,
                model.email,
                model.caracterizacao_Capital,
                model.quantidade_Quota,
                model.valor_Quota,
                model.capital_Social,
                model.estado_Civil,
                model.profissao,
                model.data_Nascimento,
                model.genero,
                model.nacionalidade,
                model.tipo_Pessoa,
                model.nacional,
                model.situacao
            );
            _context.SaveChanges();

            return NoContent();
        }

        // PUT api/packages/123
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pessoa = _context.Pessoas.SingleOrDefault(p => p.Id == id);

            if (pessoa == null)
                return NotFound();

            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
