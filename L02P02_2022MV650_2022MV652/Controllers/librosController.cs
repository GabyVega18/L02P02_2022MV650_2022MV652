using Microsoft.AspNetCore.Mvc;
using L02P02_2022VF650_2022MV652.Models;

namespace L02P02_2022VF650_2022MV652.Controllers
{
    public class librosController : Controller
    {
        // Simulación de datos (usa la misma lista que en autoresController)
        private static List<libros> listaLibros = new List<libros>
        {
            new libros { id = 1, nombre = "Cien años de soledad", id_autor = 1, descripcion = "Obra maestra", url_imagen = "", id_categoria = 1, precio = 15.50, estado = "Disponible" },
            new libros { id = 2, nombre = "El amor en los tiempos del cólera", id_autor = 1, descripcion = "Otra joya", url_imagen = "", id_categoria = 1, precio = 13.00, estado = "Disponible" },
            new libros { id = 3, nombre = "La casa de los espíritus", id_autor = 2, descripcion = "Realismo mágico", url_imagen = "", id_categoria = 1, precio = 12.75, estado = "Agotado" }
        };

        // Acción para ver todos los libros
        public IActionResult Index()
        {
            return View(listaLibros);
        }

        // Acción para ver detalles de un libro
        public IActionResult Detalle(int id)
        {
            var libro = listaLibros.FirstOrDefault(l => l.id == id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);
        }
    }
}
