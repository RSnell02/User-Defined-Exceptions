/*
 * Project: Spr2020-UserDefinedException
 * Filename: Program.cs
 * Author: R. Snell
 * Date: Feb. 17, 2020
 * Purpose: To calculate the square root of a number.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr2020_UserDefinedException
{
    class Program
    {
        static void Main(string[] args)
        {
            var again = true;   // Loop control variable

            do
            {
                // Catch any NegativeNumberException throws
                try
                {
                    Console.Write("Enter a value to calculate the square root " +
                        " root of: ");
                    double inVal = double.Parse(Console.ReadLine());
                    double result = SquareRoot(inVal);

                    Console.WriteLine($"The square root of {inVal} is " +
                        $"{result:F6}\n");
                    again = false;
                }   // end try
                catch(FormatException formatEx)
                {
                    Console.WriteLine("\n" + formatEx.Message);
                    Console.WriteLine("Please enter a double value. \n");
                }   // end catch
                catch (NegativeNumberException nnEx)
                {
                    Console.WriteLine("\n" + nnEx.Message);
                    Console.WriteLine("Please enter a non-negative value.\n");
                }   // end NegativeNumberException
            } while (again);    // end do-while
        }   // end Main()

        // SquareRoot() method computes the square root of the parameter:
        // It throws a NegativeNumberException if paramter is negative.
        public static double SquareRoot(double val)
        {
            // if negative operant, throws negative number exception
            if (val < 0)
            {
                throw new NegativeNumberException(
                    "Square root of negative number not permitted.");
            }
            else
            {
                return Math.Sqrt(val);  // Calculate the square root
            }   // end if-else
        }   // end SquareRoot()
    }   // end class
}   // end namespace
