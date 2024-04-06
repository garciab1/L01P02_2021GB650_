using System.ComponentModel.DataAnnotations;

namespace L01P02_2021GB650_.Models
{
    public class materias
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Materia")]
        public string? materia { get; set; }

        [Display(Name = "Unidades Valoraticas")]
        public int? unidades_valorativas { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }



    }
}
