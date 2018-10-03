using System;
using Domain.Enumerations;

namespace Domain.Interfaces
{
    public interface ICar : IVehicle
    {
        string Model {get;set;}
        string Engine {get;set;}
        int Doors {get;set;}
        int Wheels {get;set;}
        CarBodyType BodyType {get;set;}
    }
}
