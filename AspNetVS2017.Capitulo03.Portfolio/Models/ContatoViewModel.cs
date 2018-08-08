using System.ComponentModel.DataAnnotations;

namespace AspNetVS2017.Capitulo03.Portfolio.Models
{
    public class ContatoViewModel
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        //[RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email com formato inválido.")]
        public string Email { get; set; }

        [Required]
        public string Mensagem { get; set; }
    }
}