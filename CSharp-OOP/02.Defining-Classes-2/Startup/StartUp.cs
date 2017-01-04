namespace Points
{
    using System;

    class StartUp
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(6);

            //Adding Elements
            for (int i = 0; i < 10; i++)
            {
                list.AddElement(i);
            }
            Console.WriteLine("Display all elements of the generic list");
            Console.WriteLine(list.ToString());

            //Removing Elements by Index
            list.RemoveElementByIndex(1);
            Console.WriteLine("Display all elements of the generic list after removing one at given index");
            Console.WriteLine(list.ToString());

            list.InsertElementAtIndex(99, 1);
            Console.WriteLine("Display all elements of the generic list after inserting one at given index");
            Console.WriteLine(list.ToString());

            //Finding elements by their value
            Console.WriteLine("Finding if element is contained in the generic list");
            list.FindElementByValue(5);

            //Clearing our generic list
            list.ClearList();
            Console.WriteLine("Clearing the generic list");
            Console.WriteLine(list.ToString());
        }
    }
}
