using WebApplication1.models;

namespace WebApplication1.repositories
{
    public interface IAlunoRepository
    {
        public void Cadastrar(Aluno aluno);
        public void Atualizar(Aluno aluno);
        public void Deletar(string ra);
        public List<Aluno> ObterTodos();
    }
}
