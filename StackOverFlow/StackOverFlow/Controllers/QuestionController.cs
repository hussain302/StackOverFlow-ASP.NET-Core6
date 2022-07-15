using Microsoft.AspNetCore.Mvc;
using StackOverFlow.Interfaces.BlogInterfaces;
using StackOverFlow.Mappers;
using StackOverFlow.Models.Blogs;

namespace StackOverFlow.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IBlogRepository service;
        private readonly ICategoryRepository service1;
        private readonly ICommentRepository service2;

        public QuestionController(IBlogRepository service, ICategoryRepository service1, ICommentRepository service2)
        {
            this.service = service;
            this.service1 = service1;
            this.service2 = service2;
        }

        public IActionResult Index()
        {

            ViewBag.UserName = HttpContext.Session.GetString("Name");
            var models = service.GetBlogs().Select(x => x.ConvertToWebModel()).ToList();
            return View(models);
        }

        public IActionResult AskQuestion()
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            ViewBag.Category =  service1.GetCategorys()
                                    .Select(x=>x.ConvertToWebModel()).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AskQuestion(BlogModel model)
        {
            int UserId =(int) (HttpContext.Session.GetInt32("Id"));

            model.UserId = UserId;
            model.CommentId = null;

            service.AddBlog(model.ConvertToDomainModel());
            return RedirectToAction("Index");
        }
        public IActionResult EditQuestion(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            ViewBag.Category =  service1.GetCategorys()
                                    .Select(x=>x.ConvertToWebModel()).ToList();

            var find  = service.GetBlog(id);
            return View(find.ConvertToWebModel());
        }

        [HttpPost]
        public IActionResult EditQuestion(BlogModel model)
        {
            int UserId =(int) (HttpContext.Session.GetInt32("Id"));

            model.UserId = UserId;
            model.CommentId = null;

            service.UpdateBlog(model.ConvertToDomainModel());
            return RedirectToAction("Index");
        }
        
        
        public IActionResult DeleteQuestion(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("Name");
            ViewBag.Category =  service1.GetCategorys()
                                    .Select(x=>x.ConvertToWebModel()).ToList();

            var find  = service.GetBlog(id);
            return View(find.ConvertToWebModel());
        }

        [HttpPost]
        public IActionResult DeleteQuestion(BlogModel model)
        {
            service.RemoveBlog(model.Id);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult AddComment()
        {
            return PartialView("AddComment");
        }
        [HttpPost]
        public ActionResult AddComment(CommentModel model)
        {
            service2.AddComment(model.ConvertToDomainModel());
            return RedirectToAction("Index");
        }
    }
}
