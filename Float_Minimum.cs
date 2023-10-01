using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method
{
    internal class Float_Minimum
    {
        public  Float_Minimum() 
        {
           
                float num1 = 10.5f;
                float num2 = 5.7f;
                float num3 = 8.2f;

                float minimum = FindMinimum(num1, num2, num3);
                Console.WriteLine("The minimum of the three floats is: " + minimum);
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

