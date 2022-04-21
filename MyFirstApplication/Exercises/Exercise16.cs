

namespace MyFirstApplication;

/*
Exercise16
Write a method that has no parameters and a no return type.
Create a List<T> of your Horse objects. When creating your list,
utilize all the constructors you created with your Horse class.
Using a foreach loop, printout the results of your collectionusing a
Console WriteLine statement.
 */
public class Exercise16
{
    public void Horse () //method 
    {
        List<Horse> horseObject = new List<Horse>(); //list of horse objects
        horseObject.Add(new Horse()); //first constructor 
        horseObject.Add(new Horse( "Large", 705)); //second constructor 
        horseObject.Add(new Horse("Brown", 700)); //third constructor

        foreach (Horse item in horseObject) // foreach loop
        {
            Console.WriteLine(item); //result
        }
    }
 /*Write a method that has no parameters and no return type. Using only the data 
 you used when building your favorite movies from exercise 15, create 
 a Dictionary collection that takes an int key and string value. When 
 adding Dictionaryelements,pick an int value as the key and use the 
 favorite movies data as thestring. Using a foreach loop, print out the
 results of your collection using a Console WriteLine statement.
 */

    public void MovieDictionary()
    {
        Dictionary<int, string> phrases = new Dictionary<int, string>();
        phrases.Add(10, "The_Hangover");
        phrases.Add(20, "Dirty_Dancing");
        phrases.Add(30, "Boss_Baby");
        foreach (KeyValuePair<int, string> item in phrases)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}