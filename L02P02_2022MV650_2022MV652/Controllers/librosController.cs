using Microsoft.AspNetCore.Mvc;
using L02P02_2022VF650_2022MV652.Models;


namespace L02P02_2022MV650_2022MV652.Controllers
{
    public class librosController : Controller
    {
        private readonly libreriaDbContext _context;

        public librosController(libreriaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult LibrosPorAutor(int autorId)
        {
            // Obtener los libros del autor seleccionado
            var libros = _context.libros.Where(l => l.id_autor == autorId).ToList();

            // Pasar la lista de libros a la vista
            return View(libros); // Redirigir a la vista 'LibrosPorAutor'
        }



    }
}
