using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method
{
    internal class String_Minimum
    {
        public String_Minimum() 
        {
            string str1 = "apple";
            string str2 = "Mango";
            string str3 = "Orange";

            string minimum = FindMinimum(str1, str2, str3);
            Console.WriteLine("The minimum of the three strings is: " + minimum);
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
