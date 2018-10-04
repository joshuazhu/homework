using System;
using Domain.Interfaces;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Utility.Exceptions;

namespace Repository
{
    public class MemoryRepository : IRepository
    {
        private static readonly List<IVehicle> _vehicles = new List<IVehicle>();
        private static int NextId = 1;

        public IVehicle Create(IVehicle vehicle)
        {
            vehicle.Id = NextId++;
            vehicle.CreateTime = DateTime.Now;
            _vehicles.Add(vehicle);
            return vehicle;
        }

        public void Delete(int id)
        {
            var vehicle = Get(id);
            if(vehicle == null)
            {
                throw new InvalidDataException($"Cannot find vehicle with id: {id}");
            }
            _vehicles.Remove(vehicle);
        }

        public System.Collections.Generic.IEnumerable<IVehicle> Get()
        {
            return _vehicles;
        }

        public IVehicle Get(int id)
        {
            return _vehicles.FirstOrDefault(x => x.Id == id);
        }

        public IVehicle Put(IVehicle vehicle)
        {
            var id = vehicle.Id;
            var vehicleInDb = Get(id);
            if(vehicleInDb == null)
            {
                throw new InvalidDataException($"Cannot find vehicle with id: {id}");
            }

            for(int i=0;i<=_vehicles.Count;i++)
            {
                if(id == _vehicles[i].Id)
                {
                    _vehicles[i] = vehicle;
                    return vehicle;
                }
            }
            return null;
        }
    }
}
