using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Points
{
    public class GenericList<T> where T : IComparable
    {
        //fields
        private T[] elements;

        //constructors
        public GenericList(int Capacity)
        {
            this.elements = new T[Capacity];
            this.Count = 0;
        }

        //properties
        public int Count { get; private set; }

        //Methods
        public void AddElement(T item)
        {
            if (this.Count == elements.Length - 1)
            {
                this.Expand();
            }
            elements[Count] = item;
            this.Count++;
        }
        public T AccessElementByIndex(int index)
        {
            return this.elements[index];
        }
        public void RemoveElementByIndex(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            this.elements[this.Count - 1] = default(T);
            this.Count--;
        }
        public void InsertElementAtIndex(T item, int index)
        {
            for (int i = this.Count; i >= index; i--) // 0 2 3 4 5 6 7 8 9
            {
                elements[i + 1] = elements[i];
            }
            elements[index] = item;
            this.Count++;
        }
        public void ClearList()
        {
            T[] newElements = new T[0];
            this.elements = newElements;
        }
        public void FindElementByValue(T item)
        {
            int index = Array.IndexOf(elements, item);

            if (index >= 0)
            {
                Console.WriteLine("Found Element by value: {0}, at Index: {1}", elements[index], index);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
        private void Expand()
        {
            T[] newElements = new T[2 * this.Count];
            Array.Copy(elements, newElements, Count);
            this.elements = newElements;
        }
        public T MinElement()
        {
            var min = this.elements.Min();
            return min;
        }
        public T MaxElement()
        {
            var max = this.elements.Max();
            return max;
        }
        public override string ToString()
        {
            if (elements.Length > 0)
            {
                var result = new StringBuilder();

                for (var i = 0; i < this.Count; i++)
                {
                    result.Append(this.elements[i]);

                    if (i != this.Count - 1)
                    {
                        result.Append(", ");
                    }
                }

                return result.ToString();
            }
            else
            {
                return "List empty";
            }
        }
    }
}
