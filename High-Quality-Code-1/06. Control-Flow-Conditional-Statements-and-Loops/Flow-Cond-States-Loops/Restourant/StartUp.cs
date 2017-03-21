namespace Restourant
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            ////Task 2.1 here -------->>>>
            Potato potato = new Potato();
            var vegetables = new List<IVegetable> { potato };
            Chef chef = new Chef();

            if (vegetables.Count > 0)
            {
                foreach (var vegetable in vegetables)
                {
                    if (vegetable.IsRotten)
                    {
                        throw new ArgumentException("There is a rotten vegetable! Can't Cook.");
                    }

                    chef.Cook(vegetables);
                }
            }
            //// Task 2.2 is here ---->>>
            ////if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            ////{
            ////    VisitCell();
            ////}
        }
    }
}