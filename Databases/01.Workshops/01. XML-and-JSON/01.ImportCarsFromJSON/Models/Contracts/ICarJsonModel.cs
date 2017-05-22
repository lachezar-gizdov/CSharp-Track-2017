using ImportCarsFromJSON.Enums;

namespace ImportCarsFromJSON.Models.Contracts
{
    public interface ICarJsonModel
    {
        int Year { get; set; }

        TransmissionType TransmissionType { get; set; }

        string ManufacturerName { get; set; }

        string Model { get; set; }

        decimal Price { get; set; }

        IDealer Dealer { get; set; }
    }
}