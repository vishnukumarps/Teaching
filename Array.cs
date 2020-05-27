using System;
using System.Collections.Generic;
using System.Text;

namespace Teaching
{
    class Array
    {
        static void Main(string[] args)
        {
         
            int[] a = new int[10];
          

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i * 10;

            }
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("______________________________");

            Console.WriteLine("Array Elements are");
            for (int i = a.Length-1; i>=0; i--)
            {
                Console.WriteLine(a[i]);
            }




            Console.ReadLine();
        }
    }
}
