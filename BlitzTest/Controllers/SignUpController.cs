using Microsoft.AspNetCore.Mvc;

namespace BlitzTest.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
