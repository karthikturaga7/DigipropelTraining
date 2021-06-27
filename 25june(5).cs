/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
public class Exercise5
{
  static void Main()
  {
    int num1, num2, sum;
     
    Console.Write("Input the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Input the second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
     
    sum=num1+num2;
   
   if(num1==num2){
    sum=3*sum;
       Console.WriteLine("{0} and {1} are same so sum = {2}",num1,num2,sum);
   }
   else{
        Console.WriteLine("{0} and {1} are not same so sum = {2}",num1,num2,sum);
   }
  }
}