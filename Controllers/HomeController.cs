using Microsoft.AspNetCore.Mvc;

namespace CalebCoughenour.Controllers
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