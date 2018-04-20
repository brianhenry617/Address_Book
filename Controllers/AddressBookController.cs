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
    [HttpGet("/display")]
    public ActionResult DisplayForm()
    {
      return View("CreateForm");
    }

    // post the information and redirect user back to the homepage
    [HttpPost("/create")]
    public ActionResult CreateForm()
    {
      // get the user input ( sanitize it in the future)
      string name = Request.Form["name"];
      string phone = Request.Form["phone"];
      string address = Request.Form["address"];

      Contacts myContact = new Contacts(name,phone,address); // instantiate an object
      List<Contacts> allContact = Contacts.GetAll(); // get all for all the instances
      return View("Index",allContact); // for now

    }

    [HttpGet("/clear")]
    public ActionResult DeleteContacts()
    {
      Contacts.ClearAll(); // clear all information in the phonebook
      return View("Index"); // return the view of the html
    }


  }
}
