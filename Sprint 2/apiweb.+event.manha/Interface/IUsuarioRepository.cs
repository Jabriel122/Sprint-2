using apiweb._event.manha.Domains;
using apiweb._event.manha.ViewModel;

namespace apiweb._event.manha.Interface
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmailESenha(String email, String senha);

        void Deletar(Guid id);

    }
}
