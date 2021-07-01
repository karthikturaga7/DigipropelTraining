/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Text;
   public class Assignment10
   {
      public static void Main(string[] args) 
      {
          int n1,n2,sumString,tempS3,tempS4,sum=0;
          String s1,s2;
          Console.Write("Input the size of array1 : ");
    n1 = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input the size of array2 : ");
    n2 = Convert.ToInt32(Console.ReadLine()); 
          int[] arr1 = new int[n1] ;
          int[] arr2 = new int[n2] ;
          Console.Write("Input {0} elements in the array :\n",n1);
       for(int i=0;i<n1;i++)
            {
	      Console.Write("element - {0} : ",i);
		 arr1[i] = Convert.ToInt32(Console.ReadLine());  
	    }
	    Console.Write("Input {0} elements in the array :\n",n2);
       for(int i=0;i<n2;i++)
            {
	      Console.Write("element - {0} : ",i);
		 arr2[i] = Convert.ToInt32(Console.ReadLine());  
	    }
	    
	    string[] strArray1 = Array.ConvertAll(arr1, ele => ele.ToString());
    string[] strArray2 = Array.ConvertAll(arr2, ele => ele.ToString());
    
	    
	    tempS3=Convert.ToInt32(string.Join("", strArray1));
	    tempS4=Convert.ToInt32(string.Join("", strArray2));
	    
       sum= tempS3+tempS4;
       Console.Write("{0} + {1} = {2}" ,tempS3,tempS4,sum);
       
       
   }
}

Input:
Array 1 : 1 , 3 ,9 
Array2 : 2, 3

Expected Output:
Input the size of array1 : 3
Input the size of array2 : 2
Input 3 elements in the array :
element - 0 : 1
element - 1 : 3
element - 2 : 9
Input 2 elements in the array :
element - 0 : 3
element - 1 : 2
139 + 32 = 171