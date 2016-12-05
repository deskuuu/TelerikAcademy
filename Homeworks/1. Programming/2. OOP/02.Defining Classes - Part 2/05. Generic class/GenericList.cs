namespace _05.Generic_class
{
    using System;
 
    public class GenericList<T> where T : IComparable
    {
        // Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
        const int DefaultCapacity = 10;

        private T[] elements;
        private int count = 0;
        public int Capacty { get; set; }

        // Keep the elements of the list in an array with fixed capacity which is given as parameter 
        // in the class constructor.
        public GenericList(int capacity)
        {
            this.Capacty = capacity;
            elements = new T[capacity];
        }

        public GenericList() : this(DefaultCapacity)
        {
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        // Implement methods for adding element, accessing element by index,
        // removing element by index, inserting element at given position, 
        // clearing the list, finding element by its value and ToString().
        public void AddElement(T element)
        {
            if (count >= elements.Length)
            {
                throw new IndexOutOfRangeException($"The list capacity of {elements.Length} was exceeded.");
            }
            elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                Check(index);
                T result = elements[index];
                return result;
            }
        }

        public void RemoveAt(int index)
        {
            Check(index);
            for (int i = index; i < Count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            count--;
        }

        public void InsertAt(int index, T element)
        {
            Check(index);
            elements[index] = element;
            elements[count++] = default(T);
        }

        public void Clear()
        {
            elements = new T[DefaultCapacity];
        }

        public int Find(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        // Implement auto-grow functionality: when the internal array is full, 
        // create a new array of double size and move all elements to it.
        void Grow()
        {
            var oldElements = elements;
            Capacty *= 2;
            elements = new T[Capacty];
            Array.Copy(oldElements, elements, Count);
        }
        //Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
        public T Min()
        {
            T min = elements[0];
            foreach (T element in elements)
            {
                if (min.CompareTo(element) > 0)
                {
                    min = element;
                }
            }
            return min;
        }

        public T Max()
        {
            T max = elements[0];
            foreach (T element in elements)
            {
                if (max.CompareTo(element) < 0)
                {
                    max = element;
                }
            }
            return max;
        }

        public override string ToString()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{elements[i]}");
            }
            return "";
        }

        // Check all input parameters to avoid accessing elements at invalid positions.
        private void Check(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException($"Invalid index: {index}.");
            }
        }
    }
}
