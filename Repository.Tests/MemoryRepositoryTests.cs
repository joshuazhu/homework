using Domain;
using Xunit;
using System;
using Domain.Interfaces;
using Domain.Enumerations;

namespace Repository.Tests
{
    public class MemoryRepositoryTests
    {
        [Fact]
        public void AddCar()
        {
            var repository = new MemoryRepository();
            var car = new Car()
            {
                Make = "Test Make",
                CreateTime = DateTime.Now,
                Model = "Test Model",
                Engine = "Test Engine",
                Doors = 4,
                Wheels = 4,
                BodyType = CarBodyType.HatchBack
            };

            var savedVehicle = repository.Create(car);
            var savedCar = (ICar) savedVehicle;

            Assert.True(savedVehicle.Id > 0);
            Assert.Equal(savedVehicle.Make, car.Make);

            Assert.True(savedVehicle is Car);
            Assert.Equal(savedCar.Model, car.Model);
        }
    }
}
