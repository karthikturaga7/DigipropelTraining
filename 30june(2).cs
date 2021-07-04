/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Assignment1
    {
        static void Main()
        {
            string name1, name2;
            List<string> names = new List<string>();
            Console.WriteLine("Enter First Name:");
            name1 = Console.ReadLine();
            Console.WriteLine("Enter second Name:");
            name2 = Console.ReadLine();
            names.Add(name1);
            names.Add(name2);
            
            names.Sort();
            Console.WriteLine("Sorted list of name: ");
            foreach (string s in names) 
            {
            Console.WriteLine(s);
            }
        }
    }
}