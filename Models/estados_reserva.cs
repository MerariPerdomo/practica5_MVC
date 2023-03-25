using System.ComponentModel.DataAnnotations;

namespace practicaMVC.Models
{
    public class estados_reserva
    {
        [Key]
        [Display(Name ="ID del estado de la reserva")]
        public int estado_res_id { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
