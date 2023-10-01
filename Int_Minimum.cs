using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method
{
    internal class Int_Minimum
    {
        public Int_Minimum() 
        {
            {
                int num1 = 10;
                int num2 = 5;
                int num3 = 8;

                int minimum = FindMinimum(num1, num2, num3);
                Console.WriteLine("The minimum integers is: " + minimum);
            }

            static T FindMinimum<T>(T a, T b, T c) where T : IComparable<T>
            {
                if (a.CompareTo(b) <= 0 && a.CompareTo(c) <= 0)
                {
                    return a;
                }
                else if (b.CompareTo(a) <= 0 && b.CompareTo(c) <= 0)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }

        }
    }
}
