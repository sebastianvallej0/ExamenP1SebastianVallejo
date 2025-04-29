using System.ComponentModel.DataAnnotations;

namespace ExamenP1SebastianVallejo.Models
{
    public class Cliente
    {
        [Key]
       
        public int Id { get; set; }
        [MaxLength(100)]

        public string SebastianV { get; set; } 
        public int Edad { get; set; }

        public decimal Saldo { get; set; }
        [MaxLength(100)]

        public string Email { get; set; }

        public bool EsSocio { get; set; }

        public DateTime FechaRegistro { get; set; }

        


    }
}





