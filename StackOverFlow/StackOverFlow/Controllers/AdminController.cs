using Microsoft.AspNetCore.Mvc;

namespace StackOverFlow.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Manage()
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            return View();
        }
    }
}
