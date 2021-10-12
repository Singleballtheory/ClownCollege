using Microsoft.AspNetCore.Mvc;

namespace ClownCollege.Controllers
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