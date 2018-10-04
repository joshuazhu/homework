using System;
using System.Collections.Generic;
using System.Text;
using Application.Models;
using Domain.Interfaces;
using Repository.Interfaces;

namespace Application.Services
{
    public class StoreService : IStoreService
    {
        private readonly IRepository repository;

        public StoreService(IRepository repository)
        {
            this.repository = repository;
        }

        public IVehicle Save(VehicleDTO vehicleDTO)
        {
            var vehicle = vehicleDTO.ToDomainObj();
            if(vehicle.Id <= 0)
            {
                return repository.Create(vehicle);
            }
            else
            {
                return repository.Put(vehicle);
            }
        }
    }
}
