
namespace MyFirstApplication;

/*
This class goes over Strings
*/

internal class Lesson2
{
    string myString = "Hello World";

    // String Method-Trim
    public void MyTrimExample()
    {
        string str = " Word ";
        // before trim
        Console.WriteLine(str);
        //trim
        string myTrim = str.Trim();
        // after trim
        Console.WriteLine(myTrim);
    }

    // String method - equals
    public void MyEqualsExample(string beta)
    {
        Console.WriteLine(beta.Equals("World"));
    }

    // String Methods To Upper (capitalize) to Lower
    public void MyUpperLowerExample()
    {
        Console.WriteLine(myString.ToUpper());
        Console.WriteLine(myString.ToLower());

    }


    // String Method- Length
    public int MyStringLength()
    {
        return myString.Length;


    }

    // Char- uses single quotes to identify it. Case sensitive
    public void MyExampleChar()
    {
        char myChar = 't';
        char copyright = '\u00A9';
        char something = '\x0089';
        Console.WriteLine(myChar);
        Console.WriteLine(copyright);
        Console.WriteLine(something);
    }

    // Escape Sequence
    public string MyEscapeExample()
    {
        return "That\'s a cool car. \t Can I drive it something?";
    }





} // end class







