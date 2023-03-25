using System.ComponentModel.DataAnnotations;

namespace practicaMVC.Models
{
    public class carreras
    {
        [Key]
        [Display(Name ="ID de Carrera")]
        public int carrera_id { get; set; }
        [Display(Name ="Carrera")]
        public string? nombre_carrera { get; set; }
        [Display(Name ="ID de la facultad")]
        public int facultad_id { get; set; }
    }
}
