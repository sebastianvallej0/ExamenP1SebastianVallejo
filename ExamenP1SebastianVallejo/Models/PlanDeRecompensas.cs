using ExamenP1SebastianVallejo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenP1SebastianVallejo.Models
{
    public class PlanDeRecompensas
    {

        [Key]

        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }

        public DateTime FechaInicio { get; set; }

        public int PuntosAcumulados { get; set; }

        [MaxLength(20)]
        public string TipoRecompensa { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }




    }
}

