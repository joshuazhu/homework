using Application.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public interface IStoreService
    {
        IVehicle Save(VehicleDTO vehicleDTO);
    }
}
