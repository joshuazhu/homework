using System;
using Domain.Interfaces;

namespace Domain
{
    public abstract class Vehicle : IVehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
