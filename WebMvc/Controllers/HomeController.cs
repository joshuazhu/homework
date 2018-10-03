using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Factories;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;
        private readonly IFactory factory;

        public HomeController(IRepository repository, IFactory factory)
        {
            this.repository = repository;
            this.factory = factory;
        }

        public IActionResult Index()
        {
            var vehicles = factory.Get().ToList();
            return View(vehicles);
        }
    }
}
