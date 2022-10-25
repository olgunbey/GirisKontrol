using Microsoft.AspNetCore.Mvc;

namespace KullaniciAdiSif.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Anasayfam()
        {
            return View();
        }
        public IActionResult Gecis()
        {
            return View();
        }
    }
}
