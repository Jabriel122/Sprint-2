using apiweb._event.manha.Context;
using apiweb._event.manha.Domains;
using apiweb._event.manha.Interface;

namespace apiweb._event.manha.Repositories
{
    public class PresencaEventoRepository : IPresencaEventoRepository
    {
        private readonly EventContext _eventContext;

        public PresencaEventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(PresencasEvento presencasEvento, Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastra(PresencasEvento presencasEvento)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {

            PresencasEvento presencasEvento = _eventContext.PresencasEvento.Find(id);
            _eventContext.PresencasEvento.Remove(presencasEvento);
            _eventContext.SaveChanges();
        }

        public List<PresencasEvento> Listar()
        {
            throw new NotImplementedException();
        }

        public List<PresencasEvento> ListarMinhas(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
