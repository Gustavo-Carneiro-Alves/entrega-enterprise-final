using System.ComponentModel.DataAnnotations;

namespace GS_GreenCycle.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite seu CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Digite sua senha")]
        public string Senha { get; set; }
    }
}
