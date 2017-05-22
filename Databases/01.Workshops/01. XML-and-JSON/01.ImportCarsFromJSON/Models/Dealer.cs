using ImportCarsFromJSON.Models.Contracts;

namespace ImportCarsFromJSON.Models
{
    public class Dealer : IDealer
    {
        public string City
        {
            get;

            set;
        }

        public string Name
        {
            get;

            set;
        }
    }
}
