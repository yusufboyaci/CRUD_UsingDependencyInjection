using CRUD_UsingDependencyInjection.Models.AdoNet;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_UsingDependencyInjection.Controllers
{
    public class CrudController : Controller
    {
        private readonly Logic db;
        public CrudController(Logic logic)
        {
            db = logic;
        }
        public IActionResult List()
        {
            return View();
        }
        [HttpGet]
        public IActionResult OnPost() => View();
        [HttpPost]
        public IActionResult OnPost(string username, string password)
        {
            if (db.Login(username,password))
            {
                return RedirectToAction("Home", "Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Insert() => View();
        [HttpPost]
        public IActionResult Insert(string name, string username, string password)
        {
            db.Insert(name, username, password);
            return RedirectToAction("Home", "Index");
        }
        [HttpGet]
        public IActionResult Edit() => View();
        [HttpPost]
        public IActionResult Edit(Guid Id, string name, string username, string password)
        {
            db.Update(Id, name, username, password);
            return RedirectToAction("Home", "Index");
        }
        public IActionResult Delete(Guid Id)
        {
            db.Delete(Id);
           return RedirectToAction("Home", "Index");
        }
    }
}
