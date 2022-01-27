using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Задача
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 4, 6, 2, 62, 32, 1, 86, 4, 62, 33, 1 };
            List<int> intArrayList = intArray.ToList();
            foreach(int i in intArray)
            {
                if(intArrayList.FindAll(e => e == i).Count >= 2)
                {
                    intArrayList.RemoveAll(e => e == i);
                }
            }
            
            foreach (int i in intArrayList)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
