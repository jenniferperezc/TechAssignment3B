
// Project by Jennifer Perez Cabrera

using System;
using System.IO;

namespace TechAssignment3B
{
    class Program
    {
        static void Main(string[] args)
        {

            //Manually populated an array
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10, 11, 12, 13, 14, 15, 16, 17, 19 ,20, 21, 22 ,23, 24, 25 }; 
            
            //Iterate through array with a ForEach Loop
            foreach (int i in numbers )
            {
               
               Console.Write("Element value =" + i); // Display message

            }// end of ForEach
            
        }// End of Main
    }// end of class
}// End of namespace
