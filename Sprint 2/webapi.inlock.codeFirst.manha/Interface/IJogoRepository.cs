using webapi.inlock.codeFirst.manha.Domain;

namespace webapi.inlock.codeFirst.manha.Interface
{
    public interface IJogoRepository
    {
        List<Jogo> Listar();

        Estudio BuscarPorId(Guid id);

        void Cadastrar(Jogo jogo);

        void Atualizar(Guid id, Jogo jogo);

        void Deletar(Guid id);

       
    }
}
