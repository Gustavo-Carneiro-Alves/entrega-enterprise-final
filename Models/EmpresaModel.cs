namespace GS_GreenCycle.Models
{
    public class EmpresaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Dono { get; set; }
        public string Endereco { get; set; }
        public int Cnpj  { get; set; }
        public int Telefone  { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<BicicletaModel> bicicletas { get; set; }
        public List<PatinsModel> patins { get; set; }
        public List<PatineteModel> patinetes { get; set; }
    }
}
