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
    [HttpGet("/tamas/{id}")]
    public ActionResult Show(int id)
    {
      Tama foundTama = Tama.Find(id);
      return View(foundTama);
    }

    [HttpPost("/tamas/update")]
    public ActionResult Update()
    {
      // Tama.PassTime(); 
      return RedirectToAction("Show");
    }
  }
}