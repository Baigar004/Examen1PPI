namespace Examen1PPI_ll.Clinica.Domain.Entities
{
    public class Medico
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Colegiacion { get; set; } = string.Empty;

        public int EspecialidadId { get; set; }

        public Especialidad Especialidad { get; set; } = null!;

        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
