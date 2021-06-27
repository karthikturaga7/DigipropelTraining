/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;


public class Assignment4 {
  static void Main(string[] args)
        {
           Console.WriteLine("\nInput first integer:");  
           int x = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Input second integer:");  
           int y = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Check if one is negative and one is positive:");
           Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
        }
}