/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int arr = 3;
        string Name;
        Person[] persons = new Person[arr];

        for (int i = 0; i < size; i++)
        {
            persons[i] = new Person(Name = Console.ReadLine());
           
        }

        for (int i = 0; i < arr; i++)
        {
            Console.WriteLine(persons[i]);
        }
    }
}

    public class Person
    {
        public string Name { get; set; }
          public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            Console.WriteLine("Constructors are called");
            return "Name :" + Name;
        }
         ~Person()
        {
            Name = string.Empty;
        }
    }