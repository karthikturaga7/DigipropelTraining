/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
//the position of a specified word in a given string
using System;


    public class Assignment6
    {
        public static void Main(string[] args)
        {
            string str1 = "Today is a fine thrusday morning";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("Position of the word 'is' in the said string: " + test(str1, "is"));
            Console.WriteLine("Position of the word 'fine' in the said string: " + test(str1, "fine"));
            Console.WriteLine("Position of the word 'morning' in the said string: " + test(str1, "morning"));
        }
        public static int test(string text, string word)
        {
            
            string[] arry = text.Split(' ');
            return Array.IndexOf(arry, word)+1;
       
        }
    }