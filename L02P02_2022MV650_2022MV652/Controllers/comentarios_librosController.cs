using Microsoft.AspNetCore.Mvc;
using L02P02_2022VF650_2022MV652.Models;

namespace L02P02_2022VF650_2022MV652.Controllers
{
    public class comentarios_librosController : Controller
    {
        // Simulando una lista de comentarios
        private static List<comentarios_libros> listaComentarios = new List<comentarios_libros>
        {
            new comentarios_libros { id = 1, id_libro = 1, comentarios = "Excelente libro", usuario = "Ana" },
            new comentarios_libros { id = 2, id_libro = 1, comentarios = "Me encantó la historia", usuario = "Luis" },
            new comentarios_libros { id = 3, id_libro = 2, comentarios = "Muy profundo y conmovedor", usuario = "Carlos" }
        };

        // Acción que recibe el ID del libro y filtra comentarios
        public IActionResult Index(int id_libro)
        {
            var comentarios = listaComentarios
                .Where(c => c.id_libro == id_libro)
                .ToList();

            ViewBag.IdLibro = id_libro; // Por si necesitas mostrar algo más
            return View(comentarios);
        }
    }
}

