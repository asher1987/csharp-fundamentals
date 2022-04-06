namespace MyFirstApplication;

public class Exercise2
{
    // Question 1
    public void Question1(string arg1)
    {
        Console.WriteLine("Trim() "+ arg1.Trim());
        Console.WriteLine("ToLower()" + arg1.ToLower());
        Console.WriteLine("Contains()" + arg1.Contains("tow"));
        Console.WriteLine("Length " + arg1.Length);
        Console.WriteLine("IndexOf() " + arg1.IndexOf('C'));
    }
    //Question 2
    public void Question2()
    {
        char char1 = '\u00b6';
        Console.WriteLine(char1);
    }
    // Question 3
    public void Question3()
    {
        Console.WriteLine("Jack and Jill \nwent up the hill \nto fetch " +
            "a pail of " +
            "water. \nJack fell down and broke his crown \nand " +
            "Jill came tumbling after.");
    }

    // Question 4
    public string Question4()
    {
        string name = "Ashley";
        string favoriteMovie = "The Hangover";
        string favoriteSnack = "chocolate";
        string favoriteDrink = "soda";
        return $"My name is {name}, I love to eat {favoriteSnack} and drink " +
            $"{favoriteDrink} while" +
            $" watching {favoriteMovie}!";
    }
}