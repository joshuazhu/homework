using System;

namespace Domain.Interfaces
{
    public interface IVehicle
    {
        int Id { get; set; }
        string Make { get; set; }
        DateTime CreateTime { get; set; }
    }
}
