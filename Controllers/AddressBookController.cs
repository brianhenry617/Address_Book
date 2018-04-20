using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Contacts.Models;

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
    [HttpPost("/")]
    public ActionResult Submit()
    {

    }
  }
}
