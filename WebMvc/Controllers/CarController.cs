using Application.Models;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Exceptions;

namespace WebMvc.Controllers
{
    public class CarController : Controller
    {
        private readonly IStoreService storeService;

        public CarController(IStoreService storeService)
        {
            this.storeService = storeService;
        }

        [HttpPost]
        public IActionResult Update(CarDTO car)
        {
            if(!ModelState.IsValid)
            {
                throw new InvalidDataException("Invalid model state.");
            }

            storeService.Save(car);
            return RedirectToAction("Index", "Home");
        }
    }
}
