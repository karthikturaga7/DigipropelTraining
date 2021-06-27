/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
//**Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.

using System;
public class Exercise1
{
  public static void Main()
  {
    int num1, num2, num3;
     
    Console.Write("Input the first number to multiply: ");
    num1 = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Input the second number to multiply: ");
    num2 = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Input the third number to multiply: ");
    num3 = Convert.ToInt32(Console.ReadLine());
     
    int result = num1 * num2 * num3;
    Console.WriteLine("Output: {0} x {1} x {2} = {3}", 
                        num1, num2, num3, result);
  }
}
