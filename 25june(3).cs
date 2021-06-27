/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.IO;
public class Exercise3
{
  public static void Main()
  {
     double number1,number2,number3,number4;
      
     Console.Write("Enter the First number: ");
     number1 = Convert.ToDouble(Console.ReadLine());
 
     Console.Write("Enter the Second number: ");
     number2 = Convert.ToDouble(Console.ReadLine());
 
     Console.Write("Enter the third number: ");
     number3 = Convert.ToDouble(Console.ReadLine());
     Console.Write("Enter the fourth number: ");
     number4 = Convert.ToDouble(Console.ReadLine());
 
     double result = (number1 + number2 + number3 + number4) / 4;
     Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
  number1, number2, number3, number4, result);
   }
}
 