using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practice.Models;

namespace practice.Controllers;

public class HomeController : Controller
{
   public string[] myEmployees = new string[] { "John", "Jane", "Jack", "Jill" };
   [HttpGet]
   public string [] GetEmployees()
   {
    return myEmployees;
   }
}
