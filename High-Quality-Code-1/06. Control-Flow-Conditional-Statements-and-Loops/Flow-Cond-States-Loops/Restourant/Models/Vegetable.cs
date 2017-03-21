namespace Restourant.Models
{
    using Contracts;

    public class Vegetable : IVegetable
    {
        public bool IsPeeled { get; set; }

        public bool IsRotten { get; set; }
    }
}
