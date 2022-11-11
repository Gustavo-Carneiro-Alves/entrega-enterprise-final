using GS_GreenCycle.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS_GreenCycle.Data.Map
{
    public class ReservaMap : IEntityTypeConfiguration<ReservaModel>
    {
        public void Configure(EntityTypeBuilder<ReservaModel> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.HasOne(x => x.Usuario);
        }
    }
}
