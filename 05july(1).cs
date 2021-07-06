using System;
 
public class FirstClass
{
    public static void Main(string[] args)
    {
        int arr = 3;
        Person[] persons = new Person[arr];
 
        for (int i = 0; i < arr; i++)
        {
            persons[i] = new Person() {
                Name = Console.ReadLine()
            };
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
 
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }
**//Input:
Juan
Sara
Carlos
**//Output:
Hello! My name is juan
Hello! My name is sara
Hello! My name is carlos

