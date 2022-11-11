using GS_GreenCycle.Enums;
using System.ComponentModel.DataAnnotations;

namespace GS_GreenCycle.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o email")]
        [EmailAddress(ErrorMessage = "O email não é válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o telefone")]
        [Phone(ErrorMessage = "O celular informado não é válido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite o CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Digite a data de nascimento")]
        public string DtNascimento { get; set; }

        [Required(ErrorMessage = "Informe o perfil")]
        public PerfilEnum? Perfil { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public virtual List<ReservaModel>? Reservas { get; set; }

        public int? BicicletaId { get; set; }

        public BicicletaModel? Bicicleta { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
}
