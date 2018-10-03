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
        VehicleDTO Create(IVehicle vehicle);
    }
}
