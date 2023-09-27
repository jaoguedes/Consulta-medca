namespace ConsultaMedica.Models
{
    public class Medico
    {
        public Guid MedicoId { get; set; }
        public string Nome { get; set;}

        public IEnumerable<Consulta>? Consultas { get; set; }
    }
}
