using apiweb._event.manha.Context;
using apiweb._event.manha.Domains;
using apiweb._event.manha.Interface;
using apiweb._event.manha.Utils;

namespace apiweb._event.manha.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly EventContext _eventContext;

        public EventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, Evento evento)
        {
            Evento eventoBuscar = _eventContext.Evento.Find(id);
            if (eventoBuscar != null) 
            {
                eventoBuscar.NomeEvento = evento.NomeEvento!;
                eventoBuscar.DataEvento = evento.DataEvento!;
                eventoBuscar.Descricao = evento.Descricao!;
                eventoBuscar.IdTiposEvento = evento.IdTiposEvento!;
                eventoBuscar.IdInstituicao = evento.IdInstituicao!;
            }
            _eventContext.Update(evento);
            _eventContext.SaveChanges();
        }

        public Evento BuscarPorId(Guid id)
        {
            try
            {
                Evento evento = _eventContext.Evento.Select(u => new Evento
                {
                    IdEvento = u.IdEvento,
                    NomeEvento = u.NomeEvento,
                    DataEvento = u.DataEvento,
                    Descricao = u.Descricao,
                    IdInstituicao = u.IdInstituicao,
                    IdTiposEvento = u.IdTiposEvento

                }).FirstOrDefault(u => u.IdEvento == id)!;

                if (evento != null)
                {
                    return evento;
                }
                return null!;
            }
            catch
            {
                throw;
            }
            

        }

        public void CadastrarEvento(Evento evento)
        {
            try
            {
                _eventContext.Evento.Add(evento);
                _eventContext.SaveChanges(); 
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Evento eventoBuscar = _eventContext.Evento.Find(id);
            _eventContext.Evento.Remove(eventoBuscar);
            _eventContext.SaveChanges();
        }

        public List<Evento> Listar()
        {
            return _eventContext.Evento.ToList();
        }
    }
}
