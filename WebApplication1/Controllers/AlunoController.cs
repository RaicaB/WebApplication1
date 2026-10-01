
using Microsoft.AspNetCore.Mvc;
using WebApplication1.models;

namespace Aula_H1_API.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRpository _alunoRepository;
        private static List<Aluno> ListaAlunos = new List<Aluno>();

        //SINTAXE DE UMA FUNCAO
        //Visibilidade da função: public, private e protect
        //Tipo do retorno
        //Nome da função
        //Parametros
        #region Metodos GET
        [HttpGet]
        public IActionResult Saudacao(string nome)
        {
            return Ok("Oi " + nome);
        }

        [HttpGet]
        [Route("OutraSaudacao")]
        public IActionResult Saudacao2(string nome)
        {
            return Ok("Oi " + nome);
        }
        [HttpGet]
        [Route("ListarAlunos")]
        public IActionResult ListarAlunos()
        {
            return Ok(ListaAlunos);
        }

        [HttpGet]
        [Route("ObterPorRA")]
        public IActionResult ObterPorRA(string ra)
        {
            var resultado = _alunoRepository.ObeterPorRa(ra);
            if(resultado == null)   
                return NotFound("Ra informado não existe");

            return Ok(resultado);

        }
        #endregion

        #region POST

        [HttpPost]

        public IActionResult Cadastrar(Aluno aluno)
        {
            var resultado = _alunoRepository.OberPorRa(aluno.Ra);
            ListaAlunos.Add(aluno);
            // Lógica para cadastrar o aluno, imagine que vou gravar no banco de dados

            if (resultado is null)
            {
                _alunoRepository.Cadastrar(aluno);
                return Ok("Cadastrado com sucesso");
            }
            return Ok("Aluno com Ra cadastrado com sucesso!");
        }
    



      

        #endregion


        [HttpPut]
        public IActionResult Atualizar(Aluno aluno)
        {             // Lógica para atualizar o aluno, imagine que vou gravar no banco de dados,
                      // vai la no banco de dados e atualiza os dados do aluno
            return Ok("Aluno atualizado com sucesso!");

        }
        [HttpPut]
        public IActionResult Atualiza(Aluno aluno)
        {
            var resultado = ListaAlunos
               .Where(a => a.Ra == aluno.Ra).FirstOrDefault();

         
            if (resultado == null)
            {
                return NotFound("Aluno não encontrado");
            }
            else
            {
                ListaAlunos.Remove(resultado);
                ListaAlunos.Add(aluno);
                return Ok("Aluno atualizado com sucesso!");
            }
        }
        
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            // Lógica para deletar o aluno, imagine que vou gravar no banco de dados,
            // vai la no banco de dados e deleta os dados do aluno
            return Ok("Aluno deletado com sucesso!");
        }
    [HttpDelete("{ra}")]
    public IActionResult Remover(string ra)
    {
            var resultado = _alunoRepository.ObterPorRa(ra);
        //var resultado = ListaAlunos
            // .Where(a => a.Ra == ra).FirstOrDefault();

        if (resultado is null)

        {
            return NotFound("Aluno não encontrado/ RA informado não existe");

        }

        else
        {
            ListaAlunos.Remove(resultado);
            return Ok("Aluno removido com sucesso!"); }
    
        }

    }
}


