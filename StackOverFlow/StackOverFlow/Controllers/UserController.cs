using Microsoft.AspNetCore.Mvc;
using StackOverFlow.Interfaces.UserInterfaces;
using StackOverFlow.Mappers;
using StackOverFlow.Models.Users;

namespace StackOverFlow.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository context;

        public UserController(IUserRepository context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel model)
        {
            var response = context.VerifyUser(model.ConvertToDomainModel());

            if (response != null)
            {
                HttpContext.Session.SetInt32("Id", response.Id);
                HttpContext.Session.SetString("Name", response.UserName);
            }
            if (response != null)
            {
                if(response.Role.Name == "Admin") 
                    return RedirectToAction("Manage", "Admin");
                else 
                    return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "User not found!";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserModel model)
        {
            model.RoleId = 2;
            context.AddUser(model.ConvertToDomainModel());
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("login");
        }

    }
}
