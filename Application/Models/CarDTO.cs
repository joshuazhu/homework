using Domain;
using Domain.Enumerations;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.Models
{
    public class CarDTO : VehicleDTO
    {
        public CarDTO()
        {

        }

        public CarDTO(ICar car) : base(car)
        {
            Model = car.Model;
            Engine = car.Engine;
            Doors = car.Doors;
            Wheels = car.Wheels;
            BodyType = car.BodyType;
        }

        [Required]
        [Display(Name = "Model")]
        [MinLength(1)]
        public string Model { get; set; }
        [Required]
        [Display(Name = "Engine")]
        public string Engine { get; set; }
        [Required]
        [Display(Name = "Door Number")]
        public int Doors { get; set; }
        [Required]
        [Display(Name = "Wheel Number")]
        public int Wheels { get; set; }
        [Required]
        [Display(Name = "Body Type")]
        public CarBodyType BodyType { get; set; }

        public override string GetDetails()
        {
            return $"{Model} {BodyType} {Engine} {Doors} Doors {Wheels} Wheels";
        }
        
        public override IVehicle ToDomainObj()
        {
            var car = new Car();
            UpdateDomainObj(car);
            return car;
        }

        public override void UpdateDomainObj(IVehicle vehicle)
        {
            base.UpdateDomainObj(vehicle);

            var car = vehicle as ICar;

            car.Model = Model;
            car.Engine = Engine;
            car.Doors = Doors;
            car.Wheels = Wheels;
            car.BodyType = BodyType;
        }
    }
}
