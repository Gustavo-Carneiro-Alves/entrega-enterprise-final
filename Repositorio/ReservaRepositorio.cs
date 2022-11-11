using GS_GreenCycle.Data;
using GS_GreenCycle.Models;

namespace GS_GreenCycle.Repositorio
{
    public class ReservaRepositorio : IReservaRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ReservaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ReservaModel ListarPorId(int id)
        {
            return _bancoContext.Reservas.FirstOrDefault(x => x.Id == id);
        }

        public List<ReservaModel> BuscarTodos(int usuarioId)
        {
            return _bancoContext.Reservas.Where(x => x.UsuarioId == usuarioId).ToList();
        }

        public ReservaModel Adicionar(ReservaModel reserva)
        {
            _bancoContext.Reservas.Add(reserva);
            _bancoContext.SaveChanges();
            return reserva;
        }

        public ReservaModel Atualizar(ReservaModel reserva)
        {
            ReservaModel reservaDB = ListarPorId(reserva.Id);
            if (reservaDB == null) throw new Exception("Houve um erro na atualização da reserva!");

            reservaDB.dtRetirada = reserva.dtRetirada;
            reservaDB.hrRetirada = reserva.hrRetirada;
            reservaDB.dtEntrega = reserva.dtEntrega;
            reservaDB.hrEntrega = reserva.hrEntrega;

            _bancoContext.Reservas.Update(reservaDB);
            _bancoContext.SaveChanges();

            return reservaDB;
        }

        public bool Apagar(int id)
        {
            ReservaModel reservaDB = ListarPorId(id);
            if (reservaDB == null) throw new Exception("Houve um erro na deleção da reserva!");

            _bancoContext.Reservas.Remove(reservaDB);
            _bancoContext.SaveChanges();

            return true;

        }
    }
}
