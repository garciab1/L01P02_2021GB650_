using System.ComponentModel.DataAnnotations;

namespace L01P02_2021GB650_.Models
{
    public class facultad
    {
        [Key]
        public int id { get; set; }
        public string? facultad_nombre { get; set; }

    }
}
