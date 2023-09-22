using apiweb._event.manha.Context;
using apiweb._event.manha.Domains;
using apiweb._event.manha.Interface;

namespace apiweb._event.manha.Repositories
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        private readonly EventContext _eventContext;

        public InstituicaoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Cadastrar(Instituicao instituicao)
        {
            try
            {
                _eventContext.Instituicao.Add(instituicao);
                _eventContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
