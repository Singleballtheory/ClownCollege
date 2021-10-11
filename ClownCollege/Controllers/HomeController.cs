using Microsoft.AspNetCore.Mvc;

namespace ClownCollege.Controllers
{
  public class HomeController : Controllers
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}