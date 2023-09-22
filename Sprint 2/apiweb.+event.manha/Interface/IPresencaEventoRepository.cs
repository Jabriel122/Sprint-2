using apiweb._event.manha.Domains;

namespace apiweb._event.manha.Interface
{
    public interface IPresencaEventoRepository
    {

        List<PresencasEvento> ListarMinhas(Guid id);

        void Cadastra(PresencasEvento presencasEvento);

        void Deletar(Guid id);

        void Atualizar(PresencasEvento presencasEvento, Guid id);

        List<PresencasEvento> Listar();

    }
}
