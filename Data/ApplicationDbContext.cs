using Microsoft.EntityFrameworkCore;
using Supermercado.Model;

namespace Supermercado.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public DbSet<Produto> Produtos { get; set; } = null!;
    }
}