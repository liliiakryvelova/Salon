using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ToDoList.Controllers
{
  public class ClientsController : Controller
  {
    private readonly ToDoListContext _db;

    public ClientsController(ToDoListContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(client => client.Stylist).ToList();
      return View(model);
    }

    //EDIT OUR DESCRIPTION
    public ActionResult Edit(int id)
    {
        Client thisClient = _db.Clients.FirstOrDefault(client => client.Id == id);
        ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
        return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
        _db.Entry(client).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    //UPDATING THE CONTROLLER
    public ActionResult Delete(int id)
    {
        var thisClient = _db.Clients.FirstOrDefault(client => client.Id == id);
        ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
        return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisClient = _db.Clients.FirstOrDefault(client => client.Id == id);
        _db.Clients.Remove(thisClient);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisClient = _db.Clients.FirstOrDefault(client => client.Id == id);
        ViewBag.PageTitle = "View All Clients";
        return View(thisClient);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}