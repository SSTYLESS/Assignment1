using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        public static void Main()
        {
            int[] arr = new int[100]; ;
            int i, j, k, size, unique;
            size = 5;
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < size; i++)
            {

                unique = 1;

                for (j = i + 1; j < size; j++)
                {

                    if (arr[i] == arr[j])
                    {

                        for (k = j; k < size - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        size--;
                        j--;
                        unique = 0;
                    }
                }

                if (unique != 1)
                {
                    for (j = i; j < size - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }

                    size--;
                    i--;
                }
            }

            Console.WriteLine("All unique numbers are: ");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}