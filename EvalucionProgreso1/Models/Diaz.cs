using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvalucionProgreso1.Models
{
    public class Diaz
    {
        [Key]
        
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [Range(0.01, int.MaxValue)]
        public decimal AtributoDecimal { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreCompleto { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Fecha { get; set; }

        public bool TieneBeca { get; set; }

        [ForeignKey("Celular")]

        public int Celular { get; set; }

    }
}
