using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// File: Sponge.cs
// Author Name: Het Natvarbhai Patel
// Student i'd: 0805024

namespace konjac_sponges.Controllers
{
    // code to show navigation on navbar..
    public class Sponge : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
