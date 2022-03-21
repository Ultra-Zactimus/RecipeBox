using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBox.Controllers
{
  public class TagsController : Controller
  {
    private readonly RecipeBoxContext _db;

    public TagsController(RecipeBoxContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Tag> model = _db.Tags.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      // do stuff
      return View();
    }

    [HttpPost]
    public ActionResult Create(Tag tag)
    {
      // do some other stuff
      return View();
    }

    public ActionResult Details(int id)
    {
      // do some other stuff
      return View();
    }

    public ActionResult Edit(int id)
    {
      // do some stuff
      return View();
    }

    [HttpPost]
    public ActionResult Edit(Tag tag)
    {
      // do some stuff
      return View();
    }

    public ActionResult Delete(int id)
    {
      // do some stuff
      return View();
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      // do some stuff
      return View();
    }
  }
}