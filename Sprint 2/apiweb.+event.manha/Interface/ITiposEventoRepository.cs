using apiweb._event.manha.Domains;

namespace apiweb._event.manha.Interface
{
    public interface ITiposEventoRepository
    {
        void Cadastra(TiposEvento tiposEvento);

        void Deletar(Guid Id);

        List<TiposEvento> Listar ();

        TiposEvento BuscarPorId(Guid id);

        void Atualizar(Guid id, TiposEvento tipoEvento);
    }
}
