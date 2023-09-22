using apiweb._event.manha.Domains;

namespace apiweb._event.manha.Interface
{
    public interface IComentariosEventosRepository
    {
        void Cadastrar(ComentariosEventos comentariosEventos);

        void Deletar(Guid id);

        List<ComentariosEventos> Listar();

        ComentariosEventos BuscarPorId (Guid id);
    }
}
