using apiweb._event.manha.Context;
using apiweb._event.manha.Domains;
using apiweb._event.manha.Interface;

namespace apiweb._event.manha.Repositories
{
    public class TiposEventoRepository : ITiposEventoRepository
    {

        private readonly EventContext _eventContext;

        public TiposEventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, TiposEvento tipoEvento)
        {
            TiposEvento tiposEventosBuscar = _eventContext.TiposEvento.Find(id)!;
            if (tiposEventosBuscar !=null)
            {
                tiposEventosBuscar.Titulo = tipoEvento.Titulo;
            }
            _eventContext.Update(tiposEventosBuscar);
            _eventContext.SaveChanges();
        }

        public TiposEvento BuscarPorId(Guid id)
        {
            try
            {
                TiposEvento tiposEvento = _eventContext.TiposEvento.Select(u => new TiposEvento
                {
                    IdTipoEvento = u.IdTipoEvento,
                    Titulo = u.Titulo
                }).FirstOrDefault(u => u.IdTipoEvento == id)!;

                if (tiposEvento != null)
                {
                    return tiposEvento;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Cadastra(TiposEvento tiposEvento)
        {
            try
            {
                _eventContext.TiposEvento.Add(tiposEvento);
                _eventContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Deletar(Guid Id)
        {
            TiposEvento tiposEventoBuscar = _eventContext.TiposEvento.Find(Id);
            _eventContext.TiposEvento.Remove(tiposEventoBuscar);
            _eventContext.SaveChanges();
        }

        public List<TiposEvento> Listar()
        {
            return _eventContext.TiposEvento.ToList(); 
        }
    }
}
