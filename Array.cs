using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method
{
    internal class DeleteArray1
    {
        public static void DeleteMethod(ref int[] array, int element)
        {
            array = Array.FindAll(array, item => item != element);
        }

        public static void DeleteMethod(ref double[] array, double element)
        {
            array = Array.FindAll(array, item => item != element);
        }

        public static void DeleteMethod(ref char[] array, char element)
        {
            array = Array.FindAll(array, item => item != element);
        }
    }
}
