using Microsoft.AspNetCore.Mvc;
using L02P02_2022VF650_2022MV652.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace L02P02_2022VF650_2022MV652.Controllers
{
    public class autoresController : Controller
    {
        private readonly libreriaDbContext _context;

        public autoresController(libreriaDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var listaDeAutores = (from e in _context.autores
                                select new
                                {
                                   autor =e.autor
                                }).ToList();
            ViewData["listaDeAutor"] = listaDeAutores;
          
            return View();
        }

    }
}

