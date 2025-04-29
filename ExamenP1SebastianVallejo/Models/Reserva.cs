using System.ComponentModel.DataAnnotations;

namespace ExamenP1SebastianVallejo.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        public DateTime FechaEntrada { get; set; }

        public DateTime FechaSalida { get; set; }

        public decimal ValorAPagar { get; set; }

        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; } 



        
    }
}
