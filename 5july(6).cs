using System;
public class LeapYear
{
	public static void Main()
	{
		int Year;
		Console.WriteLine("Enter the Year");//program to check if the year is leap year or not.
		Year= int.Parse(Console.ReadLine());
		if((Year%400==0) || (Year%4==0))// If it is disvible by 400 then it is a Leap Year.
		{
			Console.WriteLine(Year +" Is a Leap Year");
		}
		else 
		{ 
			
			Console.WriteLine(Year +" Is not a Leap Year");
		}
	}
	
}

/* Expected Output:

2004 is a Leap Year
 */