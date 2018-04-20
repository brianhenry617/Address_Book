using System;
using System.Collections.Generic;

namespace Contacts.Models
{

  public class Contacts
  {
    // private variable name,phone, Address
    private string _name;
    private string _phone;
    private string _address;
    private static List<Contacts> _contacts = new List<Contacts>() {}; // create a list to store the contact for all instances

    /*
    Description: This function is the constructor for this class
    @param name: it's the given user's name
    @param phone: it's the given user's phone Number
    @param address: it's the given user's address
    */
    public Contacts(string name, string phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
    }

    // this is a getter function that will return the user name
    // @return name return the name of the user
    public string getName()
    {
      return _name;
    }
  }

}
