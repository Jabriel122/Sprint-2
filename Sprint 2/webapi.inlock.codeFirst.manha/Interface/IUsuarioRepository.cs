using webapi.inlock.codeFirst.manha.Domain;
using webapi.inlock.codeFirst.manha.ViewModels;

namespace webapi.inlock.codeFirst.manha.Interface
{
    public interface IUsuarioRepository
    {
        Usuario BuscarUsuario(String email, string senha);

        void Cadastrar(Usuario usuario);

        void Logar (LoginViewModel usuario);

    }
}
