using Microsoft.AspNetCore.Mvc;
using L02P02_2022VF650_2022MV652.Models;

namespace L02P02_2022VF650_2022MV652.Controllers
{
    public class autoresController : Controller
    {
        
        private static List<autores> listaAutores = new List<autores>
        {
            new autores { id = 1, autor = "Gabriel García Márquez" },
            new autores { id = 2, autor = "Isabel Allende" },
            new autores { id = 3, autor = "Mario Vargas Llosa" }
        };

        private static List<libros> listaLibros = new List<libros>
        {
            new libros { id = 1, nombre = "Cien años de soledad", id_autor = 1, descripcion = "Obra maestra", url_imagen = "", id_categoria = 1, precio = 15.50, estado = "Disponible" },
            new libros { id = 2, nombre = "El amor en los tiempos del cólera", id_autor = 1, descripcion = "Otra joya", url_imagen = "", id_categoria = 1, precio = 13.00, estado = "Disponible" },
            new libros { id = 3, nombre = "La casa de los espíritus", id_autor = 2, descripcion = "Realismo mágico", url_imagen = "", id_categoria = 1, precio = 12.75, estado = "Agotado" }
        };

        public IActionResult Index()
        {
            return View(listaAutores);
        }

        public IActionResult LibrosPorAutor(int id)
        {
            var librosAutor = listaLibros.Where(l => l.id_autor == id).ToList();
            ViewBag.NombreAutor = listaAutores.FirstOrDefault(a => a.id == id)?.autor;
            return View(librosAutor);
        }
    }
}

