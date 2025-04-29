using ExamenP1SebastianVallejo.Models;
using System.ComponentModel.DataAnnotations;

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

        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }




    }
}

public class PlanRecompensa
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string Nombre { get; set; }
    public DateTime FechaInicio { get; set; }
    public int PuntosAcumulados { get; set; }
    [MaxLength(20)]
    public string TipoRecompensa { get; set; } 
    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }
}