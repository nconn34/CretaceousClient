using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CretaceousClient.Models;

namespace CretaceousClient.Controllers
{
    public class AnimalsController: Controller
    {

      public IActionResult Index()
      {
        var allAnimals = Animal.GetAnimals();
        return View(allAnimals);
      }
   }
}
