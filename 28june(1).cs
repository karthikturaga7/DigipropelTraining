/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

namespace june28
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int[] arr = new int[] { 2, 8, 5 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum=sum+arr[i];
            }
            Console.WriteLine(sum);
            
        }
    }
}