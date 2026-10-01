using System.ComponentModel.DataAnnotations;
using Microsoft.OpenApi.MicrosoftExtensions;
using WebApplication1.models.validation;

namespace WebApplication1.models
{
    /// <summary>
    // // if string.IsNullOrEmpty(aluno.Nome))
    // return BadRequest("O nome é obrigatório");
    /// </summary>
   
    public class Aluno
    {

        [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public  string Nome{ get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        public  string Email { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório")]
        public  string Ra { get; set; }

        [IdadeValidation(ErrorMessage = "Idade Invalida")]
        [Required(ErrorMessage = "A idade é obrigatória")]
        public string Idade { get; set; }
    }
}
