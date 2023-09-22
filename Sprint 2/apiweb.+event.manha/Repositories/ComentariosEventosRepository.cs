using apiweb._event.manha.Context;
using apiweb._event.manha.Domains;
using apiweb._event.manha.Interface;

namespace apiweb._event.manha.Repositories
{
    public class ComentariosEventosRepository : IComentariosEventosRepository
    {
        private readonly EventContext _eventContext;

        public ComentariosEventosRepository()
        {
            _eventContext = new EventContext();
        }

        public ComentariosEventos BuscarPorId(Guid id)
        {
            try
            {
                ComentariosEventos comentariosEventos = _eventContext.ComentariosEventos.Select(u => new ComentariosEventos
                {
                    IdComentarioEventos = u.IdComentarioEventos,
                    Descricao = u.Descricao,
                    IdUsuario = u.IdUsuario,
                    IdEvento = u.IdEvento

                }).FirstOrDefault(u => u.IdComentarioEventos == id)!;

                if (comentariosEventos != null)
                {
                    return comentariosEventos;
                }
                return null!;
            }
            catch
            {
                throw;
            }
        }

        public void Cadastrar(ComentariosEventos comentariosEventos)
        {
            try
            {
                _eventContext.Add(comentariosEventos);
                _eventContext.SaveChanges();

            }
            catch
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            ComentariosEventos comentariosEventosBuscar = _eventContext.ComentariosEventos.Find(id);
            _eventContext.ComentariosEventos.Remove(comentariosEventosBuscar);
            _eventContext.SaveChanges();
        }

        public List<ComentariosEventos> Listar()
        {
            return _eventContext.ComentariosEventos.ToList();
        }
    }
}
