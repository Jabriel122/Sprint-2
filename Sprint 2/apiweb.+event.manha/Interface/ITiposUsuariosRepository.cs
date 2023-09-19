using apiweb._event.manha.Domains;

namespace apiweb._event.manha.Interface
{
    public interface ITiposUsuariosRepository
    {
        void Cadastrar(TiposUsuario tiposUsuario);

        void Deletar(Guid id);

        List<TiposUsuario> Listar ();

        TiposUsuario BuscarPorId(Guid id);

        void Atualizar (Guid id, TiposUsuario tipoUsuarios);
    }
}
