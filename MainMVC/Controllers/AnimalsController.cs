using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MainMVC.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MainMVC.Controllers
{
    [Route("[controller]")]
    public class AnimalsController : Controller
    {
     

        private readonly ZooDbContext _context;

        public AnimalsController(ZooDbContext context)
        {
           _context = context;
        }

        public IActionResult Index()
        {
            var animals = _context.AnimalsTbs.ToList();
            return View(animals);
        }

    }
}