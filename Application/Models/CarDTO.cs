using Domain.Enumerations;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    public class CarDTO : VehicleDTO
    {
        public CarDTO(ICar car) : base(car)
        {
            Model = car.Model;
            Engine = car.Engine;
            Doors = car.Doors;
            Wheels = car.Wheels;
            BodyType = car.BodyType;
        }

        public string Model { get; set; }
        public string Engine { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public CarBodyType BodyType { get; set; }

        public override string GetDetails()
        {
            return $"{Model} {BodyType} {Engine} {Doors} Doors {Wheels} Wheels";
        }
    }
}
