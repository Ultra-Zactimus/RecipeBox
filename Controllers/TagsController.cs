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
      List<Tag> model = _db.tags.ToList();
      return View(model);
    }
  }
}