using GS_GreenCycle.Models;

namespace GS_GreenCycle.Repositorio
{
    public interface IReservaRepositorio
    {
        ReservaModel ListarPorId(int id);
        List<ReservaModel> BuscarTodos(int usuarioId);
        ReservaModel Adicionar(ReservaModel reserva);
        ReservaModel Atualizar(ReservaModel reserva);
        bool Apagar(int id);
    }
}
