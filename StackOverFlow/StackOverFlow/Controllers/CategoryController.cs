using Microsoft.AspNetCore.Mvc;
using StackOverFlow.DataAccess.BlogRepositories;
using StackOverFlow.Interfaces.BlogInterfaces;
using StackOverFlow.Mappers;
using StackOverFlow.Models.Blogs;

namespace StackOverFlow.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository service;

        public CategoryController(ICategoryRepository service)
        {
            this.service = service;
        }

        public IActionResult Manage()
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");            
            return View(service.GetCategorys().Select(x => x.ConvertToWebModel()));
        }

        public IActionResult Create()
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            service.AddCategory(model.ConvertToDomainModel()); 
            return RedirectToAction("Manage");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            var model = service.GetCategory(id);
            return View(model.ConvertToWebModel());
        }

        [HttpPost]
        public IActionResult Edit(CategoryModel model)
        {
            service.UpdateCategory(model.ConvertToDomainModel());
            return RedirectToAction("Manage");
        }
        public IActionResult Delete(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            var model = service.GetCategory(id);
            return View(model.ConvertToWebModel());
        }

        [HttpPost]
        public IActionResult Delete(CategoryModel model)
        {
            service.RemoveCategory(model.Id);
            return RedirectToAction("Manage");
        }
    }
}