using Microsoft.AspNetCore.Mvc;

namespace BlitzTest.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
