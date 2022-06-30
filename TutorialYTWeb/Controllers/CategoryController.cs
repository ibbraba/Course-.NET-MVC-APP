using Microsoft.AspNetCore.Mvc;
using TutorialYTWeb.Data;
using TutorialYTWeb.Models;

namespace TutorialYTWeb.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> ObjCategoryList = _db.Categories.ToList();



            return View(ObjCategoryList);
        }
    }
}
