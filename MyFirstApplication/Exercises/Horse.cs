namespace MyFirstApplication;


internal class Horse
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

    //attributes as properties
    public string Horsecolor { get; init; }
    public int Horseweight { get; init; }
    public string Horsesize { get; init; }

    //first constructor 
    public Horse(string color, int weight, string size)
    {
        //parameters are equal to properties
        Horsecolor = color;
        Horseweight = weight;
        Horsesize = size;
    }

    // second constructor
    public Horse(string Horsecolor, int Horseweight)
       : this(Horsecolor, Horseweight, "Large") { }

    //third constructor
    public Horse()
        : this("Brown", 700) { }

    //adding method for horse
    public virtual void HorseMethod() //added virtual keyword for exericse 12
    {

    }

    public virtual void HorseMethod(int Topspeed)
    {
        //Console.WriteLine with parameter
        Console.WriteLine($"My horse can run {Topspeed} mph in a race.");
    }
    /*
     *In your Horseclass, add the virtual keyword to your method created in 
     *Lesson 10. Create a second version of the same method and add a parameter.
     *Include a Console WriteLine method in the new method that uses the 
     *parameter. This parameter needs to be based on one of your properties.
    */
}


