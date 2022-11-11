using System.ComponentModel.DataAnnotations;

namespace GS_GreenCycle.Models
{
    public class BicicletaModel
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Tipo { get; set; }

        public string Modelo { get; set; }

        public UsuarioModel? Usuario { get; set; }

        public List<ReservaModel>? Reservas { get; set; }

    }
}
