using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ContactInformations.Models;

namespace AddressBooks.Controllers
{
  public class AddressBook : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(); // return the view of the html
    }

    // redirect user to /create form when they hit create button
    [HttpGet("/create")]
    public ActionResult CreateForm()
    {
      return View();
    }

    // post the information and redirect user back to the homepage
    [HttpPost("/create")]
    public ActionResult Submit()
    {
      // get the user input ( sanitize it in the future)
      string name = Request.Form["name"];
      string phone = Request.Form["phone"];
      string address = Request.Form["address"];

      Contacts myContact = new Contacts(name,phone,address); // instantiate an object
      List<Contacts> allContact = Contacts.GetAll(); // get all for all the instances
      return View("Index",allContact); // for now

      [HttpGet("/clear")]
      public ActionResult Clear()
      {
        Contacts.ClearAll(); // clear the all the information in the list
        return View("Index"); // redirect user back to the front page
      }

    }
  }
}
