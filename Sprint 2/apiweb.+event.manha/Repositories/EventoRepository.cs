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


        public Evento BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void CadastrarEvento(Evento evento)
        {
            try
            {
                evento.NomeEvento = Criptografia.GerarHash(evento.NomeEvento!);

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
            throw new NotImplementedException();
        }
    }
}
