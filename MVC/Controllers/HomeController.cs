using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
namespace MobileStore.Controllers
{
    public class HomeController : Controller
    {
        Context db;
        public HomeController(Context context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Mains.ToList());
        }
    }
}