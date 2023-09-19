using apiweb._event.manha.Context;
using apiweb._event.manha.Domains;
using apiweb._event.manha.Interface;
using apiweb._event.manha.Utils;
using Microsoft.EntityFrameworkCore;

namespace apiweb._event.manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EventContext _eventContext;

        public UsuarioRepository()  
        {
            _eventContext = new EventContext();
        }
        public Usuario BuscarPorEmailESenha(string email, string senha)
        {
           try
            {
                Usuario usuarioBuscado = _eventContext.Usuario.FirstOrDefault(u => u.Email == email);

                if(usuarioBuscado != null!)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if(confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null;
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
           try
            {
                Usuario usuario = _eventContext.Usuario
               .Select(u => new Usuario
               {
                   IdUsuario = u.IdUsuario,
                   Nome = u.Nome,
                   TiposUsuario = new TiposUsuario
                   {
                       Titulo = u.TiposUsuario!.Titulo
                   }
               }).FirstOrDefault(u => u.IdUsuario == id)!;

                if(usuario != null)
                {
                    return usuario;
                }
                return null!;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha);

                _eventContext.Usuario.Add(usuario);
                _eventContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        9
        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
