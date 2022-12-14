using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class TamasController : Controller
  {
    [HttpGet("/tamas")]
    public ActionResult Index()
    {
      Tama tama = new Tama("cow",1,1,1);
      return View(tama);
    }
  }
}