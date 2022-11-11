using GS_GreenCycle.Data.Map;
using GS_GreenCycle.Models;
using Microsoft.EntityFrameworkCore;

namespace GS_GreenCycle.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
        }
        public DbSet<ReservaModel> Reservas { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<BicicletaModel> Bicicletas { get; set; }
        public DbSet<EmpresaModel> Empresas { get; set; }
        public DbSet<PatineteModel> Patinetes { get; set; }
        public DbSet<PatinsModel> Patins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReservaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
