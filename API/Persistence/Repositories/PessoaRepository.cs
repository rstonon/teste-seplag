using API.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.Persistence.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly PessoaContext _context;
        public PessoaRepository(PessoaContext context)
        {
            _context = context;
        }
        public void Add(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
        }

        public void Ativar(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            _context.SaveChanges();
        }

        public void Delete(Pessoa pessoa)
        {
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
        }

        public void Desativar(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            _context.SaveChanges();
        }

        public List<Pessoa> GetAll()
        {
            return _context.Pessoas.ToList();
        }

        public Pessoa GetById(int id)
        {
            return _context.Pessoas.SingleOrDefault(p => p.Id == id);
        }

        public void Update(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            _context.SaveChanges();
        }
    }
}
