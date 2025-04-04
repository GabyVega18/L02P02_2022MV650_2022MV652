using Microsoft.AspNetCore.Mvc;

namespace L02P02_2022MV650_2022MV652.Controllers
{
    public class librosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
