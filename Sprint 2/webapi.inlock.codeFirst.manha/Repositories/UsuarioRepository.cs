using webapi.inlock.codeFirst.manha.Contexts;
using webapi.inlock.codeFirst.manha.Domain;
using webapi.inlock.codeFirst.manha.Interface;
using webapi.inlock.codeFirst.manha.Utils;

namespace webapi.inlock.codeFirst.manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Variável privada e somente leitura para armazenar os dados do contexto 
        /// </summary>
        private readonly InlockContext ctx;

        /// <summary>
        /// Contrutor do repositório
        /// Toda vez que o repositório for instanciado,
        /// Ele terá acesso aos dados fornecidos pelo contexto
        /// </summary>
        public UsuarioRepository()
        {
            ctx = new InlockContext();
        }

        //A maneira aqui de cima é só uma das maneira de instancia o objeto ctx
        //A outra maniera é simples:
        //InlockContext ctx = new inlockContext();

        public Usuario BuscarUsuario(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {

            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                ctx.Add(usuario);

                ctx.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
           
            
        }
    }
}
