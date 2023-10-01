using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method
{
    internal class DeleteArray3<T>
    {
        private T[] array;

        public DeleteArray3(T[] inputArray)
        {
            array = inputArray;
        }

        public void DeleteMethod(T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(array[i], element))
                {
                    array[i] = default(T);
                }
            }
        }

        public void DisplayArray()
        {
            Console.WriteLine("Updated Array:");
            foreach (T item in array)
            {
                if (!EqualityComparer<T>.Default.Equals(item, default(T)))
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }

    }
}
