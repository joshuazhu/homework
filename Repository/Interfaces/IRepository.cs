using System;
using System.Collections.Generic;
using Domain.Interfaces;

namespace Repository.Interfaces
{
    public interface IRepository
    {
        IEnumerable<IVehicle> Get();
        IVehicle Get(int id);
        void Delete(int id);
        IVehicle Create(IVehicle vehicle);
        IVehicle Put(IVehicle vehicle);
    }
}
