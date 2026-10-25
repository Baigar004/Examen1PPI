namespace Examen1PPI_ll.Clinica_Infrastructure.Persistence.Mappings;
using Examen1PPI_ll.Clinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

 
    public class EspecialidadMapping
        : IEntityTypeConfiguration<Especialidad>
    {
        public void Configure(EntityTypeBuilder<Especialidad> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
