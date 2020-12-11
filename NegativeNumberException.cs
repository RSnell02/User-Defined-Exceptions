/*
 * Project: Spr2020-UserDefinedException
 * Filename: NegativeNumberException.cs
 * Author: R. Snell
 * Date: Feb. 17, 2020
 * Purpose: This class will calculate the square root.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr2020_UserDefinedException
{
    class NegativeNumberException : Exception
    {
        // Default constructor
        public NegativeNumberException() : base(
            "Illegal operation for a negative number. ")
        {}   // end constructor

        // Constructor for customiziong error message
        public NegativeNumberException(string messageValue) : base(
            messageValue)
        { } // end constructor

        // Constructor for customizing the exception's error message and
        // specifying the InnerException object
        public NegativeNumberException(string messageValue, Exception Inner)
            : base(messageValue, Inner)
        { } // end constructor
    }   // end class
}   // end namespace
