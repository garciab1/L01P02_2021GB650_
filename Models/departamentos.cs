using System.ComponentModel.DataAnnotations;

namespace L01P02_2021GB650_.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Departamento")]
        public string? departamento { get; set; }

    }
}
