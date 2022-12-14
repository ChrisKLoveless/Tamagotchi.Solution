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
      List<Tama> allTamas = Tama.GetAll();
      return View(allTamas);
    }

    [HttpGet("/tamas/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/tamas")]
    public ActionResult Create(string name)
    {
      Tama myTama = new Tama(name);
      return RedirectToAction("Index");
    }

    [HttpPost("/tamas/delete")]
    public ActionResult Delete()
    {
      Tama.ClearAll();
      return View();
    }
  }
}