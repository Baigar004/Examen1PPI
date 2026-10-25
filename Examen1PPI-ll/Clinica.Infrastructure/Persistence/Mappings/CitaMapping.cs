namespace Examen1PPI_ll.Clinica_Infrastructure.Persistence.Mappings;
using Clinica.Domain.Entities;
using Examen1PPI_ll.Clinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CitaMapping : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Fecha)
            .IsRequired();

        builder.Property(c => c.Motivo)
            .IsRequired()
            .HasMaxLength(250);
    }
}