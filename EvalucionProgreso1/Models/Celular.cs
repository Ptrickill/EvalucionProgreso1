using System.ComponentModel.DataAnnotations;

namespace EvalucionProgreso1.Models
{
    public class Celular
    {
        public int Celular { get; set; }

        [Required]
        [StringLength(100)]
        public string Modelo { get; set; }

        [Required]
        [Range(2000, 2100)]
        public int Año { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Precio { get; set; }

        public int Id {  get; set; }
        


    }
}
