namespace Restourant.Models
{
    using Contracts;

    public class Potato : IVegetable
    {
        public bool IsPeeled { get; set; }

        public bool IsRotten { get; set; }
    }
}
