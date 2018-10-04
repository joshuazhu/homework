using Application.Enumerations;
using Application.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Factories
{
    public interface IFactory
    {
        IEnumerable<VehicleDTO> Get();
        VehicleDTO Get(int id, VehicleType type);
        VehicleDTO Create(IVehicle vehicle);
        VehicleDTO Create(VehicleType type);
    }
}
