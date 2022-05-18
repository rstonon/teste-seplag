using API.Entities;
using System.Collections.Generic;

namespace API.Persistence
{
    public class PessoaContext
    {
        public PessoaContext()
        {
            Pessoas = new List<Pessoa>();
        }
        public List<Pessoa> Pessoas { get; set; }
    }
}
