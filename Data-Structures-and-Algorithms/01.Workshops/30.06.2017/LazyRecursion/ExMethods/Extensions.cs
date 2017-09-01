using LazyTypes;
using System;

namespace ExMethods
{
    public static class Extensions
    {
        public static Lazy<int> Length<T>(this List<T> list)
        {
            return list.WithList(new Lazy<int>(() => 0),
                (head, tail) => new Lazy<int>(() => 1 + tail.Value.Length().Value));
        }

        public static Lazy<T> Head<T>(this List<T> list)
        {
            return list.WithList(new Lazy<T>(() => throw new Exception("Empty List")), 
                (head, tail) => new Lazy<T>(() => head.Value)
                );
        }

        public static Lazy<List<T>> Tail<T>(this List<T> list)
        {
            return list.WithList(new Lazy<List<T>>(() => throw new Exception("Empty List")),
                (head, tail) => new Lazy<List<T>>(() => tail.Value)
                );
        }

        public static Lazy<T> Last<T>(this List<T> list)
        {
            return list.WithList(new Lazy<T>(() => throw new Exception("Empty List")),
                (head, tail) => new Lazy<T>(() => )
                );
        }
    }
}
