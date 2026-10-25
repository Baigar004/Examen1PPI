namespace Examen1PPI_ll.Clinica_Infrastructure.Persistence.Mappings;
using Examen1PPI_ll.Clinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MedicoMapping : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Nombre)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.Colegiacion)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasOne(m => m.Especialidad)
            .WithMany(e => e.Medicos)
            .HasForeignKey(m => m.EspecialidadId)
            .IsRequired();

        builder.HasMany(m => m.Citas)
            .WithOne(c => c.Medico)
            .HasForeignKey(c => c.MedicoId)
            .IsRequired();
    }
}