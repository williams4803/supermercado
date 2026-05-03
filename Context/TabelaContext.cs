using System;
using Microsoft.EntityFrameworkCore;
using Supermercado.Model;

namespace Supermercado.Data
{
    [Obsolete("Use ApplicationDbContext instead.")]
    public class TabelaContextLegacy : DbContext
    {
        public TabelaContextLegacy(DbContextOptions<TabelaContextLegacy> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public DbSet<Produto> Produtos { get; set; } = null!;

    }
}
