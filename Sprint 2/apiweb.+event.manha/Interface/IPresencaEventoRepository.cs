using apiweb._event.manha.Domains;

namespace apiweb._event.manha.Interface
{
    public interface IPresencaEventoRepository
    {

        List<PresencasEvento> ListarMinhas(Guid id);

    }
}
