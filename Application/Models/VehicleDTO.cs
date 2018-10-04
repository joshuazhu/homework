using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.Models
{
    public abstract class VehicleDTO
    {
        public VehicleDTO()
        {

        }

        public VehicleDTO(IVehicle vehicle)
        {
            Id = vehicle.Id;
            Make = vehicle.Make;
            CreateTime = vehicle.CreateTime;
        }
        public int Id { get; set; }
        [Required]
        [Display(Name = "Make")]
        public string Make { get; set; }
        public DateTime CreateTime { get; set; }

        public abstract string GetDetails();
        public abstract IVehicle ToDomainObj();
        public virtual void UpdateDomainObj(IVehicle vehicle)
        {
            vehicle.Id = Id;
            vehicle.Make = Make;
            vehicle.CreateTime = CreateTime;
        }
    }
}
