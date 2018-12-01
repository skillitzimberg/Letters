using Microsoft.AspNetCore.Mvc;
using Letters.Models;

namespace Letters.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
