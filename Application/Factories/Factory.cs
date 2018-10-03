using System;
using System.Collections.Generic;
using System.Text;
using Application.Models;
using Domain.Interfaces;
using Repository.Interfaces;
using System.Linq;

namespace Application.Factories
{
    public class Factory : IFactory
    {
        private readonly IRepository repository;

        public Factory(IRepository repository)
        {
            this.repository = repository;
        }

        public VehicleDTO Create(IVehicle vehicle)
        {
            if(vehicle is ICar)
            {
                return new CarDTO((ICar)vehicle);
            }
            throw new NotImplementedException();
        }

        public IEnumerable<VehicleDTO> Get()
        {
            return repository.Get().Select(x => Create(x));
        }
    }
}
