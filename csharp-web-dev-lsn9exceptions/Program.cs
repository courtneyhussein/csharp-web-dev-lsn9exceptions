using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        //Method for division.
        static double Divide(double x, double y)
        {
            return x / y;
        }
        
        //Method to check file extension
        static int CheckFileExtension(string fileName)
        {
            try
            {
                if (fileName == null || fileName == "")
                {
                    throw new ArgumentException("Parameter must not be null or an empty string.");
                }
                else if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
                {
                    return 1;

                }
                else
                {
                    return 0;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("hi");
                return 0;
            }
            
        }
        

        static void Main(string[] args)
        {
            //Prompt user to enter two methods.
            Console.WriteLine("Enter a number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            double y = Convert.ToDouble(Console.ReadLine());

            try
            {
                if (y == 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot equal zero.");
                }
                else
                {
                    Console.WriteLine(Divide(x, y));
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine();//Print empty line for formatting.

            
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            //Call the method on each of the file names in the dictionary.
            foreach (var pair in students)
            {
                Console.WriteLine($"Score for proper file extention: {CheckFileExtension(pair.Value)}");
            }


        }
    }
}
