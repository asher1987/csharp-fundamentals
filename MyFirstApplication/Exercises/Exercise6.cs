namespace MyFirstApplication;
public class Exercise6
{

    //Write a constructor for your exercise file that takes 2 parameters.
    //The first parameter should have an int type and a variable name of
    //showSize. The second parametershould have a string type and a variable
    //name of shoeType. Create private class variablesfor these types and use
    //and under scorewhen defining them. Inside the constructor associate the
    //class variables with the constructor parameters.



    private int _shoeSize;
    private string _shoeType;

    public void Question1(int size, string type)
    {
        _shoeSize = size;
        _shoeType = type;
    }

    //Write the properties for the class variables defined in exercise 1.
    //Ensure they are labeled as public and are spelled using a capital letter.


    // properties
    public string shoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }

    }

    public int showSize
    {
        get { return _shoeSize; }
        set { _shoeSize = value; }
    }


    //Write a delegate that takes a string parameter. This delegate should
    //be named TryOn. Write a method that takes a string argument and void return
    //type. In the method body include a Console WriteLinestatement that will
    //print the message. Test your delegate in Program.cs to ensure everything
    //works properly. Using a mult-line comment on your Exercise6.csfile,
    //provide the information you used to test the delegate.

    public delegate void TryOn(string type);

    public void TryOnClothes(string message)
    {
        Console.WriteLine($"TryOnClothes = {message}");
    }

}



/* void Exercise6()
{
    Exercise6 myclothes = new Exercise6(2, "shirt");
Exercise6.TryOn theClothes = myclothes.TryOnClothes;
theClothes($"I tried on a {myclothes.showSize}");
}

*/