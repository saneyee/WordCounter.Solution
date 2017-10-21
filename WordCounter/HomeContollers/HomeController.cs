using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/results")]
    public ActionResult Result()
    {
      RepeatCounter Counter = new RepeatCounter(Request.Form["str"], Request.Form["word"]);
      return View (Counter);
    }
  }
}
