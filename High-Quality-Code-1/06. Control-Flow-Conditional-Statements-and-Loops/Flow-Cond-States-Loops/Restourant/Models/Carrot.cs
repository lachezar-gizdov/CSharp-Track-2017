namespace Restourant.Models
{
    using System;
    using Contracts;

    public class Carrot : IVegetable
    {
        public bool IsPeeled { get; set; }

        public bool IsRotten { get; set; }
    }
}
