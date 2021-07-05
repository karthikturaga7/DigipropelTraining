/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

public class astrickB
    {
         public static void Main(string[] args)
	{
            int lvert, lhorz;
			 
            for (lvert = 0; lvert <= 6; lvert++)
            {
                for (lhorz = 0; lhorz <= 6; lhorz++)
                {
					
                    if (lhorz == 1 || ((lvert == 0 || lvert == 3 || lvert == 6) && (lhorz < 5 && lhorz > 1)) || (lhorz == 5 && (lvert != 0 && lvert != 3 && lvert != 6)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
}