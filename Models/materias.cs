﻿using System.ComponentModel.DataAnnotations;

namespace L01P02_2021GB650_.Models
{
    public class materias
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }


        public string? materia { get; set; }


        public int? unidades_valorativas { get; set; }


        public string? estado { get; set; }



    }
}
