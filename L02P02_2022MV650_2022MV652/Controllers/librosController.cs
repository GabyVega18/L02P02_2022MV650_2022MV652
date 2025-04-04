using Microsoft.AspNetCore.Mvc;
using L02P02_2022VF650_2022MV652.Models;
using System.Linq;

namespace L02P02_2022VF650_2022MV652.Controllers
{
    public class librosController : Controller
    {
        private readonly libreriaDbContext _context;

        public librosController(libreriaDbContext context)
        {
            _context = context;
        }

        // Acción que muestra todos los libros
        public IActionResult Index()
        {
            var libros = _context.libros.ToList();
            return View(libros);
        }

        // Acción que muestra los libros de un autor específico
        public IActionResult LibrosPorAutor(int autorId)
        {
            var libros = _context.libros.Where(l => l.id_autor == autorId).ToList();
            return View(libros);
        }
    }
}


