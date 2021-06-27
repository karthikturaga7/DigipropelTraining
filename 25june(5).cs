/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
public class Assignment5 {
  static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(2,2));
            Console.WriteLine(SumTriple(12,10));
            Console.WriteLine(SumTriple(-5,2));          
        }
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b)*3 : a + b;
        }
}