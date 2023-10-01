namespace Generic_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("SELECT PROGRAM YOU WANT TO RUN");
                Console.WriteLine("\n1.Given 3 Integers find the minimum.\n3.Given 3 strings find the minimum.\n2.Given 3 Floats find the minimum.");
                int option = Convert.ToInt32(Console.ReadLine());
                int[] intArray = { 1, 2, 3, 4, 5 };
                double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
                char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
                int elementToDeleteInt = 3;
                double elementToDeleteDouble = 4.4;
                char elementToDeleteChar = 'b';
                switch (option)
                {
                    case 1:
                        Int_Minimum minimum = new Int_Minimum();

                        break;

                    case 2:
                        String_Minimum string_Minimum = new String_Minimum();
                        break;

                    case 3:
                        Float_Minimum float_Minimum = new Float_Minimum();
                        break;
                        case 4:                      

                        Console.WriteLine("Original Arrays:");
                        Console.WriteLine("Int Array: " + string.Join(", ", intArray));
                        Console.WriteLine("Double Array: " + string.Join(", ", doubleArray));
                        Console.WriteLine("Char Array: " + string.Join(", ", charArray));
                                           
                        DeleteArray1.DeleteMethod(ref intArray, elementToDeleteInt);
                        DeleteArray1.DeleteMethod(ref doubleArray, elementToDeleteDouble);
                        DeleteArray1.DeleteMethod(ref charArray, elementToDeleteChar);

                        Console.WriteLine("\nArrays After Deleting Elements:");
                        Console.WriteLine("Int Array: " + string.Join(", ", intArray));
                        Console.WriteLine("Double Array: " + string.Join(", ", doubleArray));
                        Console.WriteLine("Char Array: " + string.Join(", ", charArray));
                        break;
                        case 5:
                        Console.WriteLine("Original Arrays:");
                        Console.WriteLine("Int Array: " + string.Join(", ", intArray));
                        Console.WriteLine("Double Array: " + string.Join(", ", doubleArray));
                        Console.WriteLine("Char Array: " + string.Join(", ", charArray));

                        var intDeleteArray = new Delete_Array2<int>();
                        var doubleDeleteArray = new Delete_Array2<double>();
                        var charDeleteArray = new Delete_Array2<char>();
                                               

                        intDeleteArray.DeleteMethod(ref intArray, elementToDeleteInt);
                        doubleDeleteArray.DeleteMethod(ref doubleArray, elementToDeleteDouble);
                        charDeleteArray.DeleteMethod(ref charArray, elementToDeleteChar);

                        Console.WriteLine("\nArrays After Deleting Elements:");
                        Console.WriteLine("Int Array: " + string.Join(", ", intArray));
                        Console.WriteLine("Double Array: " + string.Join(", ", doubleArray));
                        Console.WriteLine("Char Array: " + string.Join(", ", charArray));
                                            
                        break;
                        case 6:
                        DeleteArray3<int> intDelete = new DeleteArray3<int>(intArray);
                        DeleteArray3<double> doubleDelete = new DeleteArray3<double>(doubleArray);
                        DeleteArray3<char> charDelete = new DeleteArray3<char>(charArray);

                        intDelete.DeleteMethod(3);
                        doubleDelete.DeleteMethod(4.4);
                        charDelete.DeleteMethod('b');

                        intDelete.DisplayArray();    
                        doubleDelete.DisplayArray();  
                        charDelete.DisplayArray();




                        break;
                }
            }

        }
    }
}