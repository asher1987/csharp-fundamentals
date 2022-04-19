namespace MyFirstApplication;

/*Create a child class based on your Horse object.
 * Include one child attribute as an auto property. Create 3 constructors. 
 * The first constructorshould have 3 parameters with 3
 * of them from Horse and your child property. 
 * Using the keyword :base(),you will put the 3 horse 
 * parameters in the parenthesis. In the body of the constructor 
 * you will assign your child parameter to your property.
 * 
 * The second constructorshould have 2 parameters, 2 based on the horse and 
 * 1 from your child. Using the :this()keyword, you will pass 2 of the 
 * parent attributes and your child attribute information to the first 
 * constructor.Include default values to represent the 1 remaining horse 
 * parameters
 * 
 * For the last constructor, you will create the default constructor. 
 * Using the :this()keyword, you will pass 2default valuesin that will 
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
        Horsecolor = color;
        Horseweight = weight;
        Horsesize = size;
    }

    //constructor 2
    public Pony(string color, int age)
    
     :this(color, 700, "small", age)
            {

        }
    // third constructor-default
    public Pony()
        : this("Brown", 700, "small", 5) { }
    }

