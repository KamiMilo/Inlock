using inlock_codefirst.Domains;
using Microsoft.EntityFrameworkCore;

namespace inlock_codefirst.Contexts
{
    public class InlockContext : DbContext
    {
        //definir Entidades do banco de dados

        public DbSet<Estudio> Estudios { get; set; }

        public DbSet<Jogo> Jogo { get; set; }

        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        /// <summary>
        /// Define as opções de cotrução do banco(String de Conexão)
        /// </summary>
        /// <param name="optionsBuilder">Objeto com as configurações definidas</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= NOTE07-S14; Database = inlock_games_codefirst; User Id =sa ;pwd= Senai@134 ; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
