using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TipoUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CategoriaChamado> CategoriasChamado { get; set; }
        public DbSet<Prioridade> Prioridades { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<InteracaoChamado> InteracoesChamado { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações adicionais do modelo podem ser feitas aqui
            base.OnModelCreating(modelBuilder);
        }
    }
}