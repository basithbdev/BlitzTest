using Microsoft.AspNetCore.Mvc;

namespace BlitzTest.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult ManageUsers()
        {
            return View();
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        public IActionResult AddSubCategory()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult ManageOrders()
        {
            return View();
        }


    }
}
