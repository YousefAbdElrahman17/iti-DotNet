using System.Collections.Generic;
 
namespace Day6
{
    public static class CollectionHelper
    {
        public static T FindMax<T>(List<T> list) where T : IComparable<T>
        {
            T max = list[0];
            foreach (T item in list)
            {
                if (item.CompareTo(max) > 0) max = item;
            }
            return max;
        }
        public static T FindMin<T>(List<T> list) where T : IComparable<T>
        {
            T min = list[0];
            foreach (T item in list)
            {
                if (item.CompareTo(min) < 0) min = item;
            }
            return min;
        }
    }
}