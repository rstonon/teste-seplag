using API.Entities;
using API.Models;
using API.Persistence;
using API.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using Serilog;
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
        /// <summary>
        /// Listar todas as pessoas cadastradas.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var pessoas = _repository.GetAll();

            Log.Information("Listou todas as pessoas cadastradas.");

            return Ok(pessoas);
        }

        // GET api/packages/123
        /// <summary>
        /// Buscar o cadastro de uma pessoa através do Id
        /// </summary>
        /// <param name="id">Id a ser passado para buscar a pessoa.</param>
        /// <returns>Objeto buscado.</returns>
        /// <response code="200" >Ok.</response>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var pessoa = _repository.GetById(id);

            if (pessoa == null)
                return NotFound();

            Log.Information("Pesquisou a pessoa " + pessoa.Razao_Social + " com o Id " + pessoa.Id);

            return Ok(pessoa);
        }

        // POST api/pessoas
        /// <summary>
        /// Cadastrar Pessoas
        /// </summary>
        /// 
        /// <remarks>
        /// {
        ///  "cpf_Cnpj": "01508869006",
        ///  "razao_Social": "RAFAEL TONON",
        ///  "nome_Fantasia": "",
        ///  "tipo_empresa": "",
        ///  "data_Constituicao": "1991-08-07T00:00:00.702Z",
        ///  "porte": "string",
        ///  "telefone": "(54) 3522-2141",
        ///  "telefone2": "",
        ///  "telefone3": "",
        ///  "site": "",
        ///  "email": "rstonon@gmail.com",
        ///  "caracterizacao_Capital": "",
        ///  "quantidade_Quota": 0,
        ///  "valor_Quota": 0,
        ///  "capital_Social": 0,
        ///  "estado_Civil": "Solteiro",
        ///  "profissao": "Programador",
        ///  "data_Nascimento": "1991-08-07T00:00:00.702Z",
        ///  "genero": "Masculino",
        ///  "nacionalidade": "Brasileiro",
        ///  "tipo_Pessoa": "Pessoa Física",
        ///  "nacional": "Sim"
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

            Log.Information("Cadastrado pessoa " + pessoa.Razao_Social + " com o Id " + pessoa.Id);

            return CreatedAtAction("GetById", new { id = pessoa.Id }, pessoa);
        }

        // PUT api/packages/123
        /// <summary>
        /// Atualizar Pessoa através do Id
        /// </summary>
        /// <remarks>
        /// {
        ///  "cpf_Cnpj": "01508869006",
        ///  "razao_Social": "RAFAEL S TONON",
        ///  "nome_Fantasia": "",
        ///  "tipo_empresa": "",
        ///  "data_Constituicao": "1991-08-07T00:00:00.702Z",
        ///  "porte": "string",
        ///  "telefone": "(54) 3522-2141",
        ///  "telefone2": "",
        ///  "telefone3": "",
        ///  "site": "",
        ///  "email": "rstonon@gmail.com",
        ///  "caracterizacao_Capital": "",
        ///  "quantidade_Quota": 0,
        ///  "valor_Quota": 0,
        ///  "capital_Social": 0,
        ///  "estado_Civil": "Solteiro",
        ///  "profissao": "Programador",
        ///  "data_Nascimento": "1991-08-07T00:00:00.702Z",
        ///  "genero": "Masculino",
        ///  "nacionalidade": "Brasileiro",
        ///  "tipo_Pessoa": "Pessoa Física",
        ///  "nacional": "Sim"
        /// }
        /// </remarks>
        /// <param name="id">Id a ser passado para atualizar a pessoa.</param>
        /// <param name="model">Dados da Vaga.</param>
        /// <returns></returns>
        /// <response code="204">No Content.</response>
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

            Log.Information("Atualizado pessoa " + pessoa.Razao_Social + " com o Id " + pessoa.Id);

            return NoContent();
        }

        // DELETE api/packages/123
        /// <summary>
        /// Deleta a pessoa através do Id
        /// </summary>
        /// <param name="id">Id a ser passado para deletar a pessoa.</param>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <response code="204" >No Content.</response>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, Pessoa model)
        {
            var pessoa = _repository.GetById(id);

            if (pessoa == null)
                return NotFound();

            _repository.Delete(pessoa);

            Log.Information("Deletada pessoa " + pessoa.Razao_Social + " com o Id " + pessoa.Id);

            return NoContent();
        }

        // PUT api/packages/123
        /// <summary>
        /// Ativar Pessoa
        /// </summary>
        /// <param name="id">Id a ser passado para Ativar o cadastro da pessoa.</param>
        /// <returns></returns>
        /// <response code="204" >No Content.</response>
        [HttpPut("{id}/ativar")]
        public IActionResult Ativar(int id)
        {
            var pessoa = _repository.GetById(id);

            if (pessoa == null)
                return NotFound();

            if (pessoa.Situacao != Situacoes.Ativado)
                pessoa.Ativar();

            _repository.Update(pessoa);

            Log.Information("Ativada pessoa " + pessoa.Razao_Social + " com o Id " + pessoa.Id);

            return NoContent();
        }

        // PUT api/packages/123
        /// <summary>
        /// Desativar Pessoa
        /// </summary>
        /// <param name="id">Id a ser passado para Desativar o cadastro da pessoa.</param>
        /// <returns></returns>
        /// <response code="204" >No Content.</response>
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

            Log.Information("Desativada pessoa " + pessoa.Razao_Social + " com o Id " + pessoa.Id);

            return NoContent();
        }
    }
}
