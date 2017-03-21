namespace Restourant.Contracts
{
    using System.Collections.Generic;

    public interface IChef
    {
        void Cut(IVegetable vegetable);

        void Peel(IVegetable vegetable);

        void Cook(List<IVegetable> vegetables);
    }
}
