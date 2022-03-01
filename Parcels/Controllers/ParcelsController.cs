using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/create")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string to, string content, string from, int weight, string address)
    {
      Parcel myParcel = new Parcel(to, content, from, weight, address);
      return RedirectToAction("Index");
    }
  }
}