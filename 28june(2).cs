/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program
{
    static void Main(){
         int [] arr = new int[100];
         int i , j , size, count=0;
         
         Console.WriteLine("Input array size {0} =");
         size = Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine("Enter Elements in array:");
         for (i=0;i<size;i++){
             Console.WriteLine("Enter Element {0}",i);
             arr[i] = Convert.ToInt32(Console.ReadLine());
         }
         
         for(i=0;i<size;i++){
             for(j=i+1;j<size;j++){
                if (arr[i]==arr[j])
                {
                    count++;
                    break;
                }
                
             }
         }
         
        Console.WriteLine("total duplicate Elements in array : {0}", count);
    }
}    