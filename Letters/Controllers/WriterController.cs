using Microsoft.AspNetCore.Mvc;
using Letters.Models;

namespace Letters.Controllers
{
    public class WriterController : Controller
    {
        [HttpGet("/writer/new")]
        public ActionResult New()
        {
          return View();
        }

        [HttpPost("/writer")]
        public ActionResult Create(string location, string sender, string recipient)
        {
          Writer newWriter = new Writer();
          newWriter.SetLocation(location);
          newWriter.SetSender(sender);
          newWriter.SetRecipient(recipient);
          return RedirectToAction("Show");
        }

        [HttpGet("/writer")]
        public ActionResult Show()
        {
          return View();
        }

    }
}
