using System.ComponentModel.DataAnnotations;

namespace GS_GreenCycle.Models
{
    public class ReservaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a data de retirada")]
        public string dtRetirada { get; set; }

        [Required(ErrorMessage = "Digite o horario de retirada")]
        public string hrRetirada { get; set; }

        [Required(ErrorMessage = "Digite a data de entrega")]
        public string dtEntrega { get; set; }

        [Required(ErrorMessage = "Digite o horario de entrega")]
        public string hrEntrega { get; set; }

        public int? UsuarioId { get; set; }

        public UsuarioModel? Usuario { get; set; }

        public List<BicicletaModel>? Bicicletas { get; set; }

    }
}
