using Microsoft.AspNetCore.Mvc;

namespace BlitzTest.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult AllProducts()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}
