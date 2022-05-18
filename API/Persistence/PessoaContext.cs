using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace API.Persistence
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options)
        {
        }
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pessoa>(p =>
            {
                p.HasKey(p => p.Id);

            });
        }
    }
}
