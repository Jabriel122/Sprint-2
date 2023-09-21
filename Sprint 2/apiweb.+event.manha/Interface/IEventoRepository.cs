using apiweb._event.manha.Domains;

namespace apiweb._event.manha.Interface
{
    public interface IEventoRepository
    {
        void CadastrarEvento(Evento evento);

        void Deletar(Guid id);

        Evento BuscarPorId(Guid id);
    }
}
