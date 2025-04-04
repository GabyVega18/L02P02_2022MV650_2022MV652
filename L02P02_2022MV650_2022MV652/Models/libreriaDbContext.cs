using Microsoft.EntityFrameworkCore;

namespace L02P02_2022VF650_2022MV652.Models
{
    public class libreriaDbContext : DbContext
    {
        public libreriaDbContext(DbContextOptions<libreriaDbContext> options) : base(options) { }

        public DbSet<autores> autores { get; set; }
        public DbSet<libros> libros { get; set; }
        public DbSet<comentarios_libros> comentarios_libros { get; set; }
    }
}


