namespace Examen1PPI_ll.Clinica.Domain.Entities
{
    public class Cita
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public string Motivo { get; set; } = string.Empty;

        public int PacienteId { get; set; }

        public Paciente Paciente { get; set; } = null!;

        public int MedicoId { get; set; }

        public Medico Medico { get; set; } = null!;
    }
}
