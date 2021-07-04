/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
//Count the total number of words in a string
using System;  
public class Assignment5
{  
    public static void Main() 
{
    string str;
    int i, word;
	
      Console.Write("Count the total number of words in a string :");
      Console.WriteLine("Input the string : ");
      str = Console.ReadLine();
	
    word = 1;

    /* loop till end of string */
    for (int length=0; length < str.Length; length++ )
    {
       
        if(str[length]==' ' || str[length]=='\t')
        {
            word++;
        }

    
    }

   Console.Write("Total number of words in the string is : {0}\n", word);
	}
}