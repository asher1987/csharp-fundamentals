namespace MyFirstApplication;

/*Create a child class based on your Horse object.
 * Include one child attribute as an auto property. Create 3 constructors. 
 * The first constructorshould have 3 parameters with 3
 * of them from Horse and your child property. 
 * Using the keyword :base(),you will put the 3 horse 
 * parameters in the parenthesis. In the body of the constructor 
 * you will assign your child parameter to your property.
 * 
 * The second constructor should have 2 parameters, 2 based on the horse and 
 * 1 from your child. Using the :this()keyword, you will pass 2 of the 
 * parent attributes and your child attribute information to the first 
 * constructor.Include default values to represent the 1 remaining horse 
 * parameters
 * 
 * For the last constructor, you will create the default constructor. 
 * Using the :this()keyword, you will pass 2 default values in that will 
 * pass to the 2ndconstructor. Also include in the class, your method for your 
 * child class.

*/

internal class Pony : Horse
{
    //auto property 
    public int Ponyage { get; init; }

    // constructor 1
    public Pony(string color, int weight, string size, int age)
        : base(color, weight, size)
    {
        Ponyage = age;
        
    }

    //constructor 2
    public Pony(string color, int weight, int age)
    
     :this(color, weight, "small", age)
    {

    }     

        
    // third constructor-default
    public Pony()
        : this("Brown", 700, 5) { }
    }


internal class Fishing_Boat : Boat
{
    //auto property
    public int Topspeed { get; init; }

    //constructor 1
    public Fishing_Boat(string color, int weight, string size, int speed)
    {
        Topspeed = speed;
    }

    //constructor 2
    public Fishing_Boat(string color, int weight, int speed)
        :this(color, weight, "medium", speed)
    {

    }

    // third constructor
    public Fishing_Boat()
        :this("Red", 5000, 150) { }
    {

    }
}

