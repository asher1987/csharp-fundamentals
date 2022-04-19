namespace MyFirstApplication;
/*Create a class based on your Boatobject. You will follow the same 
 * instructions as exercise 1except for the following. Include your 
 * attributes as Expression Body Definition Properties.
*/
internal class Boat
{

    /* Create a class based on your Horseobject.Include your attributes as auto 
         * properties.Create 3 constructors.The first constructor should have 
         * parameters equal to your properties. Assign each parameter to your 
         * properties. The second constructorshould have 2 parameters.Using the 
         * :this () keyword,  you will pass your information to the first 
         * constructor.This includes the 2 parameters and default values.
         * For the last constructor, you will create the default constructor.
         * Using the :this () keyword, you will pass  2 default values in that 
         * will pass to the 2nd constructor.Also include in the class, your 
         * method for Horse.
         */

    //attributes as Expression Body Definition Properties
    public string Boatcolor;
    public int Boatweight;
    public string Boatsize;
    
        
    public string BoatColor
    {
        get => Boatcolor;
        set => Boatcolor = value;
    }

    public int BoatWeight
    {
        get => Boatweight;
        set => Boatweight = value;
    }

    public string BoatSize
    {
        get => Boatsize;
        set => Boatsize = value;
    }

    //first constructor 
    public Boat(string color, int weight, string size)
    {
        //parameters are equal to properties
        Boatcolor = color;
        Boatweight = weight;
        Boatsize = size;
    }

    // second constructor
    public Boat(string Boatcolor, int Boatweight)
       : this(Boatcolor, Boatweight, "Large") { }

    //third constructor
    public Boat()
        : this("Red", 700) { }

    //adding method for boat
    public virtual void BoatMethod()
    {
        Console.WriteLine($"My boat floats.");
    }


    public void BoatMethod(int price)
    {
        Console.WriteLine($"My boat will cost {price} at the boat shop.");
    }
   /* In your Boatclass, add the virtual keyword to your method created in 
    * Lesson 10. Create a second version of the same method and add a parameter
    * .Include a Console WriteLine method in the new method that uses the 
    * parameter.This parameter needs to be based on one of your properties
   */

     
}



