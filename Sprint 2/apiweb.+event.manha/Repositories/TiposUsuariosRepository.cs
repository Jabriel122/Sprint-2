using apiweb._event.manha.Context;
using apiweb._event.manha.Domains;
using apiweb._event.manha.Interface;

namespace apiweb._event.manha.Repositories
{
    public class TiposUsuariosRepository : ITiposUsuariosRepository
    {

        private readonly EventContext _eventContext;

        public TiposUsuariosRepository() 
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, TiposUsuario tipoUsuarios)
        {
            throw new NotImplementedException();
        }

        public TiposUsuario BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            _eventContext.TiposUsuarios.Add(tiposUsuario);
            _eventContext.SaveChanges(); 
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposUsuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
