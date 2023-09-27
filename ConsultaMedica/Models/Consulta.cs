using System.ComponentModel;
using System.Data;

namespace ConsultaMedica.Models
{
    public class Consulta
    {
        public Guid Id { get; set; }
        public DateTime Hora { get; set; }
        [DisplayName("Medico")]
        public Guid MedicoId { get; set; }
        public Medico? Medico { get; set; }
    }
}
