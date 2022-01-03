using Microsoft.AspNetCore.Mvc;
using Vocabook.AppData.Entities;

namespace Vocabook.Controllers
{
    public class WordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View(new WordEntity());
        }
    }
}
