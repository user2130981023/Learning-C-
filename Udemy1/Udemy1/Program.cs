using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// writeline makes the text print to a new line after that line is printed
// Write combines the text that is printed on the same line
// after the comma is what it prints the brackets specify what to print
// in the brackets ex: {0} {1} if you do {0, 5} it will take up 5 spaces no matter what
// if you add a {0, -5} it will add the space from the left to the right side of the text
// line 33 if you take away the space before the quotes end "my int is _" then the myInt variable will be right next to your text because there is no space between them



namespace DeclaringVariables
{
    class Program
    {
        // lecture 3 Displaying Variables in the Console so you can see the text
        static void Main(string[] args)
        {
            int myInt = 555; // int cannot have decimal
            double myDouble = 5.5; // double can have decimal
            string myString = "Hello World"; // a string
            bool myBool = true; // cam be true or false
            char myChar = 'A'; // char is short for character


            Console.WriteLine("The value of my int is {0} and the value of my double os {1}", myInt, myDouble);

            Console.WriteLine("The value of my int is " + myInt + " and the value of my double is " + myDouble); 

        }
    }
}