/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;  
public class Exercise11  
{  
    public static void Main() 
{
	int[] arr1 = new int[5];
    int n, i, j, tmp;
	
	
       Console.Write("\n\nSort elements of array in ascending order :\n");
       Console.Write("----------------------------------------------\n");	

    Console.Write("Input the size of array : ");
    n = Convert.ToInt32(Console.ReadLine()); 

       Console.Write("Input {0} elements in the array :\n",n);
       for(i=0;i<n;i++)
            {
	      Console.Write("element - {0} : ",i);
		 arr1[i] = Convert.ToInt32(Console.ReadLine());  
	    }

    for(i=0; i<n; i++)
    {
        for(j=i+1; j<n; j++)
        {
            if(arr1[j] < arr1[i])
            {
                tmp = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = tmp;
            }
        }
    }
    Console.Write("\nElements of array in sorted ascending order:\n");
    for(i=0; i<n; i++)
    {
        Console.Write("{0}  ", arr1[i]);
    }
		        Console.Write("\n\n");	
  }

}

INPUT: 2,7,4,5,9
Expected Output:2,4,5,7,9