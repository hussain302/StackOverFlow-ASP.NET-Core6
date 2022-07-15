using Microsoft.AspNetCore.Mvc;
using StackOverFlow.Interfaces.BlogInterfaces;
using StackOverFlow.Mappers;
using StackOverFlow.Models.Blogs;

namespace StackOverFlow.Controllers
{
    public class ClientController : Controller
    {
        private readonly IBlogRepository service;
        private readonly ICategoryRepository service1;

        public ClientController(IBlogRepository service, ICategoryRepository service1)
        {
            this.service = service;
            this.service1 = service1;
        }

        public IActionResult ViewAll()
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            var models = service.GetBlogs().Select(x => x.ConvertToWebModel()).ToList();
            return View(models);
        }
        public IActionResult HTML()
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            CategoryModel category = service1.GetCategory(1).ConvertToWebModel(); 
            var models = service.GetBlogsbyCategory(category.ConvertToDomainModel())
                .Select(x => x.ConvertToWebModel()).ToList();
            return View(models);
        }
        public IActionResult Python()
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            CategoryModel category = service1.GetCategory(2).ConvertToWebModel(); 
            var models = service.GetBlogsbyCategory(category.ConvertToDomainModel())
                .Select(x => x.ConvertToWebModel()).ToList();
            return View(models);
        }

    }
}
