using API.Entities;
using System.Collections.Generic;

namespace API.Persistence.Repositories
{
    public interface IPessoaRepository
    {
        List<Pessoa> GetAll();
        Pessoa GetById(int id);
        void Add(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Delete(Pessoa pessoa);
        void Ativar(Pessoa pessoa);
        void Desativar(Pessoa pessoa);

    }
}
