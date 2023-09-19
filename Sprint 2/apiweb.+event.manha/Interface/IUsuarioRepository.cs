using apiweb._event.manha.Domains;

namespace apiweb._event.manha.Interface
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmailESenha(String email, String senha);

        public void Deletar(Guid id);
    }
}
