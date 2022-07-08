using Microsoft.AspNetCore.Mvc;

namespace CalebCoughenour.Controllers
{
  public class ProjectsController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}