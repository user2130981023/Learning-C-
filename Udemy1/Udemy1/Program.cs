using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// + - / * %

namespace UsingArithmeticOperators
{
    class Program
    {
        // lecture 4 Using Arithmetic Operators, basically math variables
        static void Main(string[] args)
        {
            int myInt = 5 + 5; // addition
            Console.WriteLine(myInt);
            int myInt2 = 5 - 5; // subtraction
            Console.WriteLine(myInt2);
            int myInt3 = 5 * 5; // multiply
            Console.WriteLine(myInt3);

            double myDouble = 45.0 / 2; // adding the 44.0 makes it divide by decimal instead of whole number
            Console.WriteLine(myDouble);

            double remain = 5 % 4; // divides and gets the remainder after it divides 
            Console.WriteLine(remain);


            int result = (2 + 3) * 4; // does multiplication first then adds. Parenthases make it execute that math first
            Console.WriteLine("The result is {0}", result);


            int myInt4 = myInt + myInt2 + myInt3; // adds all the myInts together
            Console.WriteLine(myInt4);


            int x = 5;
            x = x + 1; // gets the value of x and adds on to it
            x += 1;
            
            Console.WriteLine("The value of x is {0}", x);

            int y = 5;
            y++; // add 1 to y
            Console.WriteLine("The value of y is {0}", y);

            int b = 4;
            int c = b++; // adds by one if it is in front and if the ++ is behind the variable it doesnt go up
            Console.WriteLine("The value of b is {0} and the value of c is {1}", b, c);
        }
    }
}