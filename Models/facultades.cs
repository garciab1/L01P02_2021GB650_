using System.ComponentModel.DataAnnotations;

namespace L01P02_2021GB650_.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Facultad")]
        public string? facultad { get; set; }

    }
}
