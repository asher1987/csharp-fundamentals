namespace MyFirstApplication;
internal class Exercise8
/* Write a constants at the class level.The constant should be Foot with a
 * value of 12 to represent the number of inches in a foot.Write a method
that takes 1 int parameterand a void return type.This method wil
convert feet to inches.The formula that you would use will be
the parameter * Foot.Your parameter will represent the number
of feet to convert to inches. Using a ConsoleWriteLinestatement,
print the results.Test your method using the number 3 to see if
    you get 36.
*/
{
    public const int Foot = 12;  

    public void FeetInches (int arg)
    {
        int inches = arg * Foot;
        Console.WriteLine(inches);


    }


    /*
    2. Write a static method that take 2 int parameters and a void return type.
    This method will be used to calculate the length and width of a 
    rectangle/square. This formula is length x width. The first parameter
    should represent the length and the second parameter should be the 
    width. Using a Console WriteLine statement, print the results. Test your 
    method and add what you used to test as a comment either before the 
    method or after.
     */

    public static void Area(int length, int width)
    {
        Console.WriteLine(length * width);
    }

    //void Exercise8Example()
//{
    //Exercise8.Area(6, 4);
//}
}

