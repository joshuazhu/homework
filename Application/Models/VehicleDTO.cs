using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    public abstract class VehicleDTO
    {
        public VehicleDTO(IVehicle vehicle)
        {
            Id = vehicle.Id;
            Make = vehicle.Make;
            CreateTime = vehicle.CreateTime;
        }
        public int Id { get; set; }
        public string Make { get; set; }
        public DateTime CreateTime { get; set; }

        public abstract string GetDetails();
    }
}
