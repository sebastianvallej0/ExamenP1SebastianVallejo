using ExamenP1SebastianVallejo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenP1SebastianVallejo.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        public DateTime FechaEntrada { get; set; }

        public DateTime FechaSalida { get; set; }

        public decimal ValorAPagar { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; } 



        
    }
}



