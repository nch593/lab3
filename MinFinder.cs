using System;

namespace Library
{
    public class MinFinder
    {
        public static T Min<T>(T a, T b)
            where T : IComparable<T>
        {
            return a.CompareTo(b) < 0 ? a : b;
        }

        public static T Min<T>(T a, T b, T c)
            where T : IComparable<T>
        {
            return Min(Min(a, b), c);
        }
    }
}
