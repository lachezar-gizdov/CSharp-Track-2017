using System;
using ImportCarsFromJSON.Enums;
using ImportCarsFromJSON.Models.Contracts;

namespace ImportCarsFromJSON.Models
{
    public class CarJsonModel : ICarJsonModel
    {
        public IDealer Dealer
        {
            get;

            set;
        }

        public string ManufacturerName
        {
            get;

            set;
        }

        public string Model
        {
            get;

            set;
        }

        public decimal Price
        {
            get;

            set;
        }

        public TransmissionType TransmissionType
        {
            get;

            set;
        }

        public int Year
        {
            get;

            set;
        }
    }
}
