using System;
public class CarProgram
{
    public interface Iveh  //using interface concepts
    {
        void Drive();
        bool Refuel(int amount);
    }
    public class Car :Iveh  // using inhertiance concepts
    {
        public int fuel{ get; set;}
        public Car(int Fuel)
        {
            fuel = Fuel ;
        }
        public void Drive()
        {
            if( fuel > 0 )
            {
                Console.WriteLine("the car is driving");
            }
            else
            {
                Console.WriteLine("no fuel");
            }
            
        }
        public bool Refuel(int amount)
        {
            fuel += amount;
            return true;
        }
    }
    
    public static void Main () // main method
    {
        Car obj1 = new Car(0);
        int Fuel = int.Parse(Console.ReadLine());
        if (obj1.Refuel(Fuel))
        {
            obj1.Drive();
        }
    }
}
*/ expected output
12
the car is driving
/*
 