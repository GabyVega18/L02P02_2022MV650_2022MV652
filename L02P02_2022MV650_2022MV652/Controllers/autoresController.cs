using Microsoft.AspNetCore.Mvc;
using L02P02_2022VF650_2022MV652.Models;

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
            var listaDeAutores = _context.autores.ToList();
            return View(listaDeAutores);
        }
    }
}


