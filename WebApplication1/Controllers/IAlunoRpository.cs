using WebApplication1.models;

namespace Aula_H1_API.Controllers
{
    internal interface IAlunoRpository
    {
        void Cadastrar(Aluno aluno);
        object OberPorRa(string ra);
        Aluno ObeterPorRa(object ra);
        Aluno ObterPorRa(string ra);
    }
}