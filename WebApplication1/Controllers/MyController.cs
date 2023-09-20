using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index(string message, int page)
        {
            ViewBag.Message = message;
            ViewBag.Page = page;
            ViewBag.Date = DateTime.Now;
            return View();
        }
        
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(int id, string name)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            
            return View();
        }
    }
}
