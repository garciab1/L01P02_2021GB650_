using Microsoft.EntityFrameworkCore;

namespace L01P02_2021GB650_.Models
{
    public class notasContext : DbContext
    {
        public notasContext(DbContextOptions<notasContext> options) : base(options)
        {

        }
    }
}
