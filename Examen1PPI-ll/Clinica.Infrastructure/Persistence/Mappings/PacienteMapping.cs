namespace Examen1PPI_ll.Clinica_Infrastructure.Persistence.Mappings;
using Examen1PPI_ll.Clinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PacienteMapping : IEntityTypeConfiguration<Paciente>
{
    public void Configure(EntityTypeBuilder<Paciente> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.NombreCompleto)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode();

        builder.Property(p => p.DNI)
            .IsRequired()
            .HasMaxLength(13)
            .IsUnicode();

        builder.Property(p => p.FechaNacimiento)
            .IsRequired();

        builder.HasMany(p => p.Citas)
            .WithOne(c => c.Paciente)
            .HasForeignKey(c => c.PacienteId)
            .IsRequired();
    }
}