/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;  
public class Assignment4
{  
    public static void Main() 
{
    string str; /* Declares a string  */
    int length= 0;
      Console.Write("---------------------------------\n"); 	
      Console.Write("Input the string : ");
      str = Console.ReadLine();

         foreach(char chr in str)
        {
            length= length + 1;

        }

   Console.Write("Length of the string is : {0}\n\n", length);
	}
}