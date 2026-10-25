namespace Examen1PPI_ll.Clinica.Domain.Entities
{
    public class Paciente
    {
        public int Id { get; set; }

        public string NombreCompleto { get; set; } = string.Empty;

        public string DNI { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }

        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
