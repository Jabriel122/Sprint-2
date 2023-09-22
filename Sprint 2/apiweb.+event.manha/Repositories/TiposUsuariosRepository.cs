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
            TiposUsuario tiposUsuarioBuscar = _eventContext.TiposUsuarios.Find(id)!;
            if(tiposUsuarioBuscar !=null)
            {
                tiposUsuarioBuscar.Titulo = tipoUsuarios.Titulo;
            }
            _eventContext.Update(tiposUsuarioBuscar);
            _eventContext.SaveChanges();
        }

        public TiposUsuario BuscarPorId(Guid id)
        {

            try
            {
                TiposUsuario tiposUsuario = _eventContext.TiposUsuarios.Select(u => new TiposUsuario
                {
                    IdTipoUsuario = u.IdTipoUsuario,
                    Titulo = u.Titulo
                }).FirstOrDefault(u => u.IdTipoUsuario == id)!;

                if (tiposUsuario != null)
                {
                    return tiposUsuario;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }

        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            _eventContext.TiposUsuarios.Add(tiposUsuario);
            _eventContext.SaveChanges(); 
        }

        public void Deletar(Guid id)
        {
            TiposUsuario tiposUsuarioBuscar = _eventContext.TiposUsuarios.Find(id);
            _eventContext.TiposUsuarios.Remove(tiposUsuarioBuscar);
            _eventContext.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
           return _eventContext.TiposUsuarios.ToList();
        }
    }
}
