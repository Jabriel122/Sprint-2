using apiweb._event.manha.Domains;
using Microsoft.EntityFrameworkCore;

namespace apiweb._event.manha.Context
{
    public class EventContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuarios { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<TiposEvento> TiposEventos { get; set; }

        public DbSet<ComentariosEventos> ComentComentariosEventos { get; set; }

        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<PresencasEvento> PresencasEvento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-VLQ1I1C; Database = event+_manha; User Id= sa; Pwd= Senai@134; TrustServerCertificate= True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
