using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int n = int.Parse(Console.ReadLine());
            int [] array= new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter element number " + i);
                array[i] = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine("the second largest number in array is " + gettingSecondLargestElement(array));
            Console.ReadLine();
        }

        private static int gettingSecondLargestElement(int [] array)
        {
            int n = array.Length;
            int temp = 0;
            for(int i = 0; i<array.Length; i++)   //1,2,8,5,6,9
            {
                for (int inner = 0; inner < array.Length-i-1; inner++)
                {
                    if (array[inner] > array[inner+1])
                    {
                        temp = array[inner];
                        array[inner] = array[inner+1];
                        array[inner+1] = temp;
                    }
                }
            }
            for(int i = n-1; i >= 0; i--)
            {
                if(array[i] != array[i-1])
                {
                    return array[i-1];
                }
            }
            return 0;
        }
    }


}
