using System;
using Domain.Enumerations;
using Domain.Interfaces;

namespace Domain
{
    public class Car : Vehicle, ICar
    {
        public string Model {get;set;}
        public string Engine {get;set;}
        public int Doors {get;set;}
        public int Wheels {get;set;}
        public CarBodyType BodyType {get;set;}
    }
}
