namespace Restourant
{
    using System.Collections.Generic;
    using Contracts;
    using Models.Utils;

    public class Chef : IChef
    {
        private Bowl bowl = new Bowl();

        public Chef()
        {
        }

        public Bowl Bowl { get; set; }

        public void Cut(IVegetable vegetable)
        {
        }

        public void Peel(IVegetable vegetable)
        {
        }

        public void Cook(List<IVegetable> vegetables)
        {
            foreach (var vegetable in vegetables)
            {
                Peel(vegetable);

                Cut(vegetable);

                this.bowl.Add(vegetable);
            }
        }
    }
}
