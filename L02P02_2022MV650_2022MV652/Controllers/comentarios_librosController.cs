using Microsoft.AspNetCore.Mvc;
using L02P02_2022VF650_2022MV652.Models;
using System.Linq;

namespace L02P02_2022VF650_2022MV652.Controllers
{
    public class comentarios_librosController : Controller
    {
        // Simulando una lista de comentarios (reemplaza con base de datos real)
        private static List<comentarios_libros> listaComentarios = new List<comentarios_libros>
        {
            new comentarios_libros { id = 1, id_libro = 1, comentarios = "Excelente libro", usuario = "Ana" },
            new comentarios_libros { id = 2, id_libro = 1, comentarios = "Me encantó la historia", usuario = "Luis" },
            new comentarios_libros { id = 3, id_libro = 2, comentarios = "Muy profundo y conmovedor", usuario = "Carlos" }
        };

        // Acción que recibe el ID del libro y filtra comentarios
        public IActionResult Index(int id)
        {
            if (id == 0)
            {
                return Content("ID de libro no válido.");
            }

            var comentarios = listaComentarios
                .Where(c => c.id_libro == id) // Aquí, 'id_libro' sigue siendo correcto ya que es el campo en la lista de comentarios
                .ToList();

            ViewBag.IdLibro = id; // Pasar el ID del libro a la vista
            return View(comentarios);
        }

        // Acción para guardar el comentario
        [HttpPost]
        public IActionResult GuardarComentario(int id_libro, string comentario, string usuario)
        {
            // Validar si los parámetros están correctamente pasados
            if (string.IsNullOrEmpty(comentario) || string.IsNullOrEmpty(usuario))
            {
                return Content("Comentario o Usuario no puede ser vacío.");
            }

            // Crear un nuevo comentario
            var nuevoComentario = new comentarios_libros
            {
                id_libro = id_libro,
                comentarios = comentario,
                usuario = usuario
            };

            // Agregar el comentario a la lista (simulando base de datos)
            listaComentarios.Add(nuevoComentario);

            // Guardar el último comentario en ViewBag
            ViewBag.UltimoComentario = nuevoComentario.comentarios;

            // Redirigir a la vista de confirmación
            return View("Confirmacion");
        }
    }
}
