//Write a method that takes 2 int parameters and an int return type.
// Using the formula for Ohm's law, determine the voltage. The first
//parameter will represent current and the second will represent restistance.
// Using the func<int, int, int> and a lamda expression, determine
// the voltage calculation and return the value.
// a. voltage = current * resistance
public class Exercise5
{



    public int Question1(int current1, int resistance1)
    {
        Func<int, int, int> voltage = (current1, resistance1) => current1 *
        resistance1;
        int value = voltage(current1, resistance1);
        return value;


    }

    //Write a method that will take 1 char parameterand a string
    //return type. Using a switchexpressionand the table below, return the
    //description. If the value does not match the grade, return the default
    //message, “Not a valid grade”
    public string Question2(char arg1)
    {
        switch (arg1)
        {
            case 'E':
                return "Excellent";

            case 'V':
                return "Very Good";
            case 'G':
                return "Good";
            case 'A':
                return "Average";
            case 'F':
                return "Fail";
            default:
                return "Not a valid grade.";

        }
    }

    //Write a method that takes 1 argumentand a void return type. Using
    //a Relational Pattern and switch expression determine a size of popcorn
    //based on the table below and using a Console WriteLine, print the
    //popcorn size.
    //Size Size Value
    //Less or equal 3 Microwave bag
    //Less or equal 16 Movie sack
    //Less or equal 32 Movie cup
    //Less or equal 64 Movie tub
    //Default We don’t have that size
    public void Question3(int popcornsize)
    {
        string result = popcornsize switch
        {
            <= 3 => "Microwave bag",
            <= 16 => "Movie sack",
            <= 32 => "Movie cup",
            <= 64 => "Movie tub",
            _ => "We don\'t have that size"
        };
        Console.WriteLine(popcornsize);
    }




        }



  