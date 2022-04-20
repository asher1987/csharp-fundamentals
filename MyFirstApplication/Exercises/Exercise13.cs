namespace MyFirstApplication;

public interface IMovement //changed class to interface
{
   int Speed { get; init; } //property with get; init;
}
//end Interface

internal abstract class WaterBirds : IMovement //abstract class
{
    public abstract int Speed { get; init; } //abstract property

    public abstract void Fly(); //abstract method
    public abstract void Splash(); //abstract method

    public WaterBirds(int speed) //constructor with int parameter 
    {
        this.Speed = speed; 
    }
}

internal class WhiteBirds : WaterBirds //derived class
{

                                      
    public override int Speed { get; init; } = 10; //implementation of property

    public override void Fly () //implementation of method
    {

        Console.WriteLine($"The swan can fly at {Speed} mph.");
    }
    

    public override void Splash () //implementation of method
    {
        Console.WriteLine("The bird makes a big splash.");
    }
    public WhiteBirds (int arg)
        : base(arg) { }
}


/*#1 In your Exercise13.cs file, change your class to an Interface and 
 * name it IMovement.
 * This interface will have 1 property. The property 
 * will have an int and called Speed. It will have a get and init.
 * 
 *# 2 Under the interface you will create an Abstract class called WaterBirds. 
 * 
 * This abstract class will implement the IMovement interface. The interface 
 * property should be implemented in the Abstract class as an abstract property. 
 * 
 * Create two abstract methods for the abstract class that is related to 
 * WaterBirds. 
 * 
 * Create a constructor that will take an int parameter and be 
 * assigned to the Speed property
 * 
 * #3 Under the Abstract class Waterbirds, create a derived class that 
 * will extend the WaterBird class. Implement the abstract methods and
 * property. Use Console Writeline statements in your methods that provide 
 * information related to the methods. One of them should use an Interpolation 
 * string and consume the Speed property.Create a constructor that will take an 
 * int parameter and use the :base()to pass that int value back to the base 
 * Abstract class.

*/


