using webapi.inlock.codeFirst.manha.Domain;

namespace webapi.inlock.codeFirst.manha.Interface
{
    public interface IUsuarioRepository
    {
        Usuario BuscarUsuario(String email, string senha);

        void Cadastrar(Usuario usuario);

    }
}
