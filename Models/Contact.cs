/*
  Name: Rio Atmadja
  Date: 20 April 2018
*/
using System;
using System.Collections.Generic;

namespace ContactInformations.Models
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
      _contacts.Add(this); // save information to the list
    }

    // this is a getter function that will return the user name
    // @return: name return the name of the user
    public string getName()
    {
      return _name;
    }
    // this is a getter function that will return the user name
    // @return: phone return the name of the user
    public string getPhone()
    {
      return _phone;
    }

    // this is a getter function that will return user's address
    // @return: address return the name of the user
    public string getAddress()
    {
      return _address;
    }

    // this is a getter function that will return the whole phone book
    // @return: returning a list of contacts
    public static List<Contacts> GetAll()
    {
      return _contacts;
    }

    // this function will clear out the list
    public static void ClearAll()
    {
      _contacts.Clear(); // clear all the contacts from the address book
    }
  }

}
