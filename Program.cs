/*
    Author: Mark Haxton
    Date: 1/30/2021
    Comments: This C# Console application is to complete class project deliverale 3 Arrays. 
*/

using System;

namespace ClassProjectDeliverable3Arrays
{
    class Program
    {
        static void Main(string[] args)
        
        {
                // Here is the manually populated array

                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            
            Console.WriteLine("This app displays an array of 25 numbers, the array is manually populated."); //Displays app note.
            Console.WriteLine(""); // Adds a blank line
            // Iterate through the array with a Foreach Loop
            foreach (int i in numbers)
                {
                    Console.WriteLine("Element value = " + i); // Writes value to console
                    Console.WriteLine(""); // Adds blank line
                }

            // Here is a auto-populated array

            Console.WriteLine(""); // Adds a blank line
            Console.WriteLine("This app displays an array of 25 numbers, The array is auto populated"); //Displays app note.
            Console.WriteLine(""); // Adds a blank line
            int[] countdown = new int[25]; // creates an array of 25 integers
            
            int pop_array = 0; // create a variable used to populate the array
            for (int i = 0; i < 25; i++) // for loop to iterate through each of the 25 elements of the array
            {
                countdown[i] = pop_array;
                Console.WriteLine("Element value = " + (i+1)); // add 1 to element value to give the desired output.
                Console.WriteLine("");
            } // end of for loop
        } 
    }
}
