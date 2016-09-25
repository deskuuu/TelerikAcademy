namespace _02.IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using IEnumerable_extensions.Constants;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : IConvertible, IComparable
        {
            CheckIfElementsAreNull(collection);

            dynamic sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            CheckIfElementsAreNull(collection);

            T product = (dynamic)1;
            foreach (var item in collection)
            {
                product = (dynamic)item * product;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            CheckIfElementsAreNull(collection);

            T min = collection.First();
            foreach (var element in collection)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            CheckIfElementsAreNull(collection);

            T max = collection.First();
            foreach (var element in collection)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            CheckIfElementsAreNull(collection);

            dynamic average = 1;
            foreach (var element in collection)
            {
                average += (dynamic)element;
            }
            return average / (dynamic)collection.Count();
        }

        private static void CheckIfElementsAreNull<T>(IEnumerable<T> elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException(Constant.EmptyMessage);
            }
        }
    }
}
