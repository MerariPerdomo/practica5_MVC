using System.ComponentModel.DataAnnotations;

namespace practicaMVC.Models
{
    public class facultades
    {
        [Key]
        [Display(Name ="ID")]
        public int facultad_id { get; set; }
        [Display(Name ="Facultad")]
        public string? nombre_facultad { get; set; }

    }
}
