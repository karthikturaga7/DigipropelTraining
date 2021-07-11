using System;
public abstract class Animal  // using abstract class
{
	private string Name;
	
	public void SetName(string name)
	{
		Name=name;
	}
	public string GetName()
	{
		return Name ;
	}
	public abstract void Eat(); // abstract method
}

public class AbstractClass
{
	public class Dog : Animal // using inhertiance concepts
{
public override  void Eat()
{
Console.WriteLine("The Dog is Eating ");
}
	public static void Main() // main method
	{
		Dog obj1 = new Dog();
		obj1.SetName(Console.ReadLine());
		Console.WriteLine (obj1.GetName());
		obj1.Eat();
	
	}
}
}
*// Expected Output
	12
The Dog is Eating 
**//



   
