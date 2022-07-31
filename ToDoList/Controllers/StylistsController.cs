using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Controllers
{
  public class StylistsController : Controller
  {
    private readonly ToDoListContext _db;

    public StylistsController(ToDoListContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

        //EDIT OUR DESCRIPTION
    public ActionResult Edit(int id)
    {
        var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
        return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
        _db.Entry(stylist).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    //UPDATING THE CONTROLLER
    public ActionResult Delete(int id)
    {
        var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
        return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
        _db.Stylists.Remove(thisStylist);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
        return View(thisStylist);
    }
   
  }
}