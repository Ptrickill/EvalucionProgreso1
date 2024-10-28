using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvalucionProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int IdCelular { get; set; }

        [Required]
        [StringLength(100)]
        public string Modelo { get; set; }

        [Required]
        [Range(2000, 2100)]
        public int Año { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Precio { get; set; }
        
        public Diaz Diaz {  get; set; }

        [ForeignKey("Diaz")]

        public int Id { get; set; }


    }
}
