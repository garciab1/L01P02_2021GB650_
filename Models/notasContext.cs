using Microsoft.EntityFrameworkCore;

namespace L01P02_2021GB650_.Models
{
    public class notasContext : DbContext
    {
        public notasContext(DbContextOptions<notasContext> options) : base(options)
        {

        }
        public DbSet<alumnos> alumnos { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<facultad> facultad { get; set; }
        public DbSet<materias> materias { get; set; }


    }
}
