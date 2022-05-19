using API.Entities;
using API.Models;
using API.Persistence;
using API.Persistence.Repositories;
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
        private readonly IPessoaRepository _repository;
        public PessoasController(IPessoaRepository repository)
        {
            _repository = repository;
        }

        // GET api/pessoas
        [HttpGet]
        public IActionResult GetAll()
        {
            var pessoas = _repository.GetAll();

            return Ok(pessoas);
        }

        // GET api/packages/123
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var pessoa = _repository.GetById(id);

            if (pessoa == null)
                return NotFound();

            return Ok(pessoa);
        }

        // POST api/pessoas
        /// <summary>
        /// Cadastrar Pessoas
        /// </summary>
        /// 
        /// <remarks>
        /// {
        ///  "cpf_Cnpj": "string",
        ///  "razao_Social": "string",
        ///  "nome_Fantasia": "string",
        ///  "tipo_empresa": "string",
        ///  "data_Constituicao": "2022-05-19T10:00:54.033Z",
        ///  "porte": "string",
        ///  "telefone": "string",
        ///  "telefone2": "string",
        ///  "telefone3": "string",
        ///  "site": "string",
        ///  "email": "string",
        ///  "caracterizacao_Capital": "string",
        ///  "quantidade_Quota": 0,
        ///  "valor_Quota": 0,
        ///  "capital_Social": 0,
        ///  "estado_Civil": "string",
        ///  "profissao": "string",
        ///  "data_Nascimento": "2022-05-19T10:00:54.033Z",
        ///  "genero": "string",
        ///  "nacionalidade": "string",
        ///  "tipo_Pessoa": "string",
        ///  "nacional": "string"
        /// }
        /// </remarks>
        /// 
        /// <param name="model">Dados da Vaga.</param>
        /// <returns>Objeto recém-criado.</returns>
        /// <response code="201" >Sucesso.</response>
        [HttpPost]
        public IActionResult Add(AddPessoaInputModel model)
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

            _repository.Add(pessoa);

            return CreatedAtAction("GetById", new { id = pessoa.Id }, pessoa);
        }

        // PUT api/packages/123
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdatePessoaInputModel model)
        {
            var pessoa = _repository.GetById(id);

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
                model.nacional
            );

            _repository.Update(pessoa);

            return NoContent();
        }

        // DELETE api/packages/123
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, Pessoa model)
        {
            var pessoa = _repository.GetById(id);

            if (pessoa == null)
                return NotFound();

            _repository.Delete(pessoa);

            return NoContent();
        }

        // PUT api/packages/123
        [HttpPut("{id}/ativar")]
        public IActionResult Ativar(int id)
        {
            var pessoa = _repository.GetById(id);

            if (pessoa == null)
                return NotFound();

            if (pessoa.Situacao != Situacoes.Ativado)
                pessoa.Ativar();

            _repository.Update(pessoa);

            return NoContent();
        }

        // PUT api/packages/123
        [HttpPut("{id}/desativar")]
        public IActionResult Desativar(int id)
        {
            var pessoa = _repository.GetById(id);

            if (pessoa == null)
                return NotFound();

            if (pessoa.Situacao != Situacoes.Desativado)
                pessoa.Desativar();
            else
            {
                return BadRequest();
            }

            _repository.Update(pessoa);

            return NoContent();
        }
    }
}
