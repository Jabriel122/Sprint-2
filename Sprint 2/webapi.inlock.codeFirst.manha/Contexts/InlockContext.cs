using Microsoft.EntityFrameworkCore;
using webapi.inlock.codeFirst.manha.Domain;

namespace webapi.inlock.codeFirst.manha.Contexts
{
    public class InlockContext : DbContext
    {
        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        
        //Definir as opções de construção do banco (String Conexão)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-VLQ1I1C; Database = inlock_game_codeFirst_manha; User Id= sa; Pwd= Senai@134; TrustServerCertificate= True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
