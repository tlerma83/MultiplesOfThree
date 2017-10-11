using System;
using System.Collections.Generic;

namespace MultiplesOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string GetMultiplesOfThree (int startNumber, int endNumber)
            {
                string numbersString = "";
                for (var i = startNumber; i <= endNumber; i++)
                {
                    if (i % 3 == 0)
                    {
                        numbersString +=(i.ToString() + ",");
                    }
                }
                return numbersString.Remove(numbersString.LastIndexOf(","));
            }       

            Console.WriteLine(GetMultiplesOfThree(1, 6));
        
        }
    }
}
