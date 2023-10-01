using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method
{
    internal class Delete_Array2<T>
    {
        public void DeleteMethod(ref T[] array, T element)
        {
            array = array.Where(item => !item.Equals(element)).ToArray();
        }

    }
}
