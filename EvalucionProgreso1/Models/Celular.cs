using System.ComponentModel.DataAnnotations;

namespace EvalucionProgreso1.Models
{
    public class Celular
    {
        public int Id { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int AtributoInt { get; set; }

        [Required]
        [Range(0.01, int.MaxValue)]
        public decimal AtributoDecimal { get; set; }

        [Required]
        [StringLength(100)]
        public string AtributoString { get; set; }

        [Required]
        public DateTime AtributoFecha { get; set; }

        public bool AtributoBool { get; set;}


    }
}
